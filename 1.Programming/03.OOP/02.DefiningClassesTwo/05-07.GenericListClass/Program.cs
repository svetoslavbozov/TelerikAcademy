
/*
5.Write a generic class GenericList<T> that keeps a list of elements of some parametric type T. Keep the elements of the list in an array with fixed capacity which is given as parameter in the class constructor. Implement methods for adding element, accessing element by index, removing element by index, inserting element at given position, clearing the list, finding element by its value and ToString(). Check all input parameters to avoid accessing elements at invalid positions.
6.Implement auto-grow functionality: when the internal array is full, create a new array of double size and move all elements to it.
7. Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the  GenericList<T>. You may need to add a generic constraints for the type T.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_07.GenericListClass
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();

            intList.Add(1);
            intList.Add(1);
            intList.Add(1);
            intList.Add(0);

            intList.InsertAt(2, 3);
            intList.Clear();
            intList[1] = 3;

            var element = intList.Find(3);

            Console.WriteLine(intList.Max<int>());
            Console.WriteLine(intList.Min<int>());

            Console.WriteLine(intList.ToString());
        }
    }
}
