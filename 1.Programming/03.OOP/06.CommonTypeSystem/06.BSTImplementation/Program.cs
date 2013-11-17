using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.BSTImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int, int> tree = new BinarySearchTree<int, int>();

            tree.Add(1, 1);
            tree.Add(2, 1);
            tree.Add(3, 1);
            tree.Add(4, 1);
            tree.Add(5, 1);
            tree.Add(6, 1);
            tree.Add(7, 1);
            tree.Add(8, 1);
            tree.Add(9, 1);
            tree.Add(10, 1);
        }
    }
}
