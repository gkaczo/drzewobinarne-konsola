using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drzewoBinarne
{
    class Program
    {


        static void Main(string[] args)
        {

            BinaryTree<int> tree = new BinaryTree<int>(5);
            //główny węzeł 

            tree.Insert(3);
            tree.Insert(10);
            tree.Insert(1);
            //  tree.Insert(3);
           //    tree.Insert(-1);
           //    tree.Insert(0);
            //   tree.Insert(4);
           //    tree.Insert(7);
           //   tree.Insert(15);
           //    tree.Insert(16);
            //  tree.Insert(19);
            //   tree.Insert(8);
            //   tree.Insert(10);
            //   tree.Insert(9);
               tree.WalkTreePreOrder();
            Console.WriteLine();

            tree.Search(3);

            //     tree.WalkTreeInOrder();
            //     Console.WriteLine();

            //    tree.WalkTreePostOrder();
            //    Console.WriteLine();

            // tree.WyswietlDrzewo();

            //   StringBuilder sb = new StringBuilder();
            //  Console.WriteLine(tree.WalkTree(sb, false));

            
            Console.ReadKey();
        }
    }
}
