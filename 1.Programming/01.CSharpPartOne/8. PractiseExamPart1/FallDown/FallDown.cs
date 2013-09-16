using System;
using System.Linq;
using System.Text;

class FallDown
{
    static void Main()
    {
        byte[,] binMatrix = new byte[8, 8];

        for (int i = 0; i < 8; i++)      
        {
            int number = int.Parse(Console.ReadLine());
            string s = Convert.ToString(number, 2); //Convert to binary in a string

            byte[] bits = s.PadLeft(8, '0') // Add 0's from left
                     .Select(c => byte.Parse(c.ToString())) // convert each char to int
                     .ToArray();

            for (int j = 0; j < 8; j++)
            {
                binMatrix[i, j] = bits[j];
            }
        }        

        for (int col = 0; col < 8; col++)
		{
            byte[] column = new byte[8];

            for (int row = 0; row < 8; row++)
			{
                column[row] = binMatrix[row,col]; 			 
			}

            Array.Sort(column);

            for (int row = 0; row < 8; row++)
            {
                binMatrix[row, col] = column[row];
            }
			 
		}

        StringBuilder build = new StringBuilder();

        for (int row = 0; row < 8; row++)
		{
			for (int col = 0; col < 8; col++)
	        {
                build.Append(binMatrix[row, col]);
	        }

            Console.WriteLine(Convert.ToInt16(build.ToString(),2));
            build.Clear();
		}
    }
}



