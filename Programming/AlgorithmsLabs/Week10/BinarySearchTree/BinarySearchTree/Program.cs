using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            /*====================================
            *   BinTree TEST
            *==================================*/
            Node<int>[] root =
                {
                    new Node<int>(1), new Node<int>(2),
                    new Node<int>(3), new Node<int>(4),
                    new Node<int>(5), new Node<int>(6),
                    new Node<int>(7), new Node<int>(8),
                    new Node<int>(9), new Node<int>(10)
               };

            root[0].Left = root[1];
            root[0].Right = root[2];
            root[1].Left = root[3];
            root[1].Right = root[4];
            root[2].Left = root[5];
            root[2].Right = root[6];
            root[4].Right = root[7];
            root[7].Left = root[8];
            root[7].Right = root[9];

            BinTree<int> bt = new BinTree<int>(root[0]);
            bt.doTraversal();

            /*====================================
             *   BSTree TEST
             *==================================*/
            BSTree<int> bst = new BSTree<int>();

            bst.InsertItem(10);
            bst.InsertItem(2);
            bst.InsertItem(30);
            bst.InsertItem(4);
            bst.InsertItem(50);
            bst.InsertItem(6);
            bst.InsertItem(70);
            bst.InsertItem(8);
            bst.InsertItem(90);
            bst.InsertItem(11);

            bst.doTraversal();


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("===============");
            Console.WriteLine("- Portfolio 9 -");
            Console.WriteLine("===============");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The Height of the BSTree is: " + bst.Height());
            Console.WriteLine("The BST Node count is: " + bst.CountBST());
            Console.WriteLine("Does the BST contain the number 90: " + bst.Contains(90));
            Console.WriteLine("Does the BST contain the number 3: " + bst.Contains(3));
           // Console.WriteLine("" + bst.RemoveItem(2));
            Console.WriteLine();

            // Portfolio Exercise 10
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("================");
            Console.WriteLine("- Portfolio 10 -");
            Console.WriteLine("================");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
           // Console.WriteLine("*** Remove Item Results will be here ***" + bst.RemoveItem(2));
           bst.RemoveItem(11);
           // Console.WriteLine("Is the item being removed still in the Tree: " + bst.Contains(11 ));
            bst.doTraversal();
            Console.WriteLine();
            // End of portfolio 10

            // Exit the program by pressing any key
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("=================================");
            Console.WriteLine("- Press any key to EXIT program -");
            Console.WriteLine("=================================");
            Console.ReadKey();
            // End of exit program

        }
    }
}
