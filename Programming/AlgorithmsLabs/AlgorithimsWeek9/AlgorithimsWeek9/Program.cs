using System;

namespace AlgorithimsWeek9
{
    class Program
    {
        static void Main(string[] args)
        {
            BSTree<int> bst = new BSTree<int>();
            bst.InsertItem(10);
            bst.InsertItem(9);
            bst.InsertItem(11);
            bst.InsertItem(8);
            bst.InsertItem(12);
            bst.InsertItem(7);
            bst.InsertItem(13);
            bst.InsertItem(6);
            bst.InsertItem(14);
            bst.InsertItem(5);
            bst.InsertItem(15);

            bst.DoTraversals();

            Console.WriteLine("\nThe height of the tree is: " + bst.GetHeight());
            Console.WriteLine("The number of nodes in the tree is: " + bst.GetCount());

            Console.WriteLine("The tree contains the number 10: " + bst.Contains(10));
            Console.WriteLine("The tree contains the number 3: " + bst.Contains(3));
            bst.RemoveItem(55);
            bst.RemoveItem(5);
            bst.DoTraversals();

            Console.ReadKey();
        }
    }
}
