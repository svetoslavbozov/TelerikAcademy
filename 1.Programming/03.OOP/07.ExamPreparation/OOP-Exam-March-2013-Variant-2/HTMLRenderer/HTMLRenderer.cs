using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace HTMLRenderer
{
    public interface IElement
    {
        string Name { get; }
        string TextContent { get; set; }
        IEnumerable<IElement> ChildElements { get; }
        void AddElement(IElement element);
        void Render(StringBuilder output);
        string ToString();
    }

    public interface ITable : IElement
    {
        int Rows { get; }
        int Cols { get; }
        IElement this[int row, int col] { get; set; }
    }

    public interface IElementFactory
    {
        IElement CreateElement(string name);
        IElement CreateElement(string name, string content);
        ITable CreateTable(int rows, int cols);
    }

    public class HtmlElement : IElement
    {
        private List<IElement> childElements;

        public string Name { get; private set; }

        public virtual string TextContent { get; set; }

        public HtmlElement(string name)
        {
            this.Name = name;
            childElements = new List<IElement>();
        }

        public HtmlElement(string name, string textContent)
            : this(name)
        {
            this.TextContent = textContent;
        }

        public virtual IEnumerable<IElement> ChildElements
        {
            get
            {
                return this.childElements;
            }
        }

        public virtual void AddElement(IElement element)
        {
            this.childElements.Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                output.AppendFormat("<{0}>", this.Name);
            }

            if (!string.IsNullOrWhiteSpace(this.TextContent))
            {
                for (int i = 0; i < this.TextContent.Length; i++)
                {
                    if (this.TextContent[i] == '<')
                    {
                        output.Append("&lt;");
                    }
                    else if (this.TextContent[i] == '>')
                    {
                        output.Append("&gt;");
                    }
                    else if (this.TextContent[i] == '&')
                    {
                        output.Append("&amp;");
                    }
                    else
                    {
                        output.Append(this.TextContent[i]);
                    }
                }
            }

            foreach (var child in this.childElements)
            {
                child.Render(output);
            }

            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                output.AppendFormat("</{0}>", this.Name);
            }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            this.Render(result);

            return result.ToString();
        }
    }

    public class HtmlTable : HtmlElement, ITable
    {
        private const string TableName = "table";
        private const string TableRowOpenTag = "<tr>";
        private const string TableRowCloseTag = "</tr>";
        private const string TableColOpenTag = "<td>";
        private const string TableColCloseTag = "</td>";

        private int rows;
        private int cols;
        private IElement[,] tableCells;

        public HtmlTable(int row, int col)
            : base(TableName)
        {
            this.Rows = row;
            this.Cols = col;
            tableCells = new IElement[row, col];
        }

        public int Rows
        {
            get { return this.rows; }
            private set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("The number of rows have to be positive integer");
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get { return this.cols; }
            private set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("The number of cols have to be positive integer");
                }

                this.cols = value;
            }
        }

        public override IEnumerable<IElement> ChildElements
        {
            get
            {
                return null;
            }
        }

        public override string TextContent
        {
            get
            {
                return null;
            }
            set
            {
                throw new InvalidOperationException("HTML tables cannot have text content");
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                IdexValidation(row, col);

                return this.tableCells[row, col];
            }
            set
            {
                IdexValidation(row, col);

                this.tableCells[row, col] = value;
            }
        }

        public override void AddElement(IElement element)
        {
            throw new InvalidOperationException("HTML tables dont have child elements");
        }

        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>", this.Name);

            for (int rows = 0; rows < this.Rows; rows++)
            {
                output.Append(TableRowOpenTag);

                for (int cols = 0; cols < this.Cols; cols++)
                {
                    output.Append(TableColOpenTag);

                    output.Append(this.tableCells[rows, cols].ToString());

                    output.Append(TableColCloseTag);
                }

                output.Append(TableRowCloseTag);
            }

            output.AppendFormat("</{0}>", this.Name);
        }

        private void IdexValidation(int row, int col)
        {
            if (this.Rows < row)
            {
                throw new IndexOutOfRangeException("Invalid row index");
            }
            if (this.Cols < col)
            {
                throw new IndexOutOfRangeException("Invalid col index");
            }
        }
    }

    public class HTMLElementFactory : IElementFactory
    {
        public IElement CreateElement(string name)
        {
            return new HtmlElement(name);
        }

        public IElement CreateElement(string name, string content)
        {
            return new HtmlElement(name, content);
        }

        public ITable CreateTable(int rows, int cols)
        {
            return new HtmlTable(rows, cols);
        }
    }

    public class HTMLRendererCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using HTMLRenderer;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }
}

