using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {
            BST test = new BST();

            test.Add(2);
            test.Add(4);
            test.Add(1);
            test.Add(3);
            test.Add(6);
            test.Add(5);

            test.PrintTree();

            test.Remove(3);
            Console.WriteLine("--------");
            test.PrintTree();
        }
    }
}
