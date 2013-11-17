/*Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods and holds a version in the format major.minor (e.g. 2.11). Apply the version attribute to a sample class and display its version at runtime.
*/

using System;

namespace _11.VersionAttribute
{
    [Version(1,1)]
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Program);

            object[] allAttributes = type.GetCustomAttributes(false);

            foreach (Version item in allAttributes)
            {
                Console.WriteLine("{0}.{1}", item.Major, item.Minor);
            }
        }
    }
}
