using System;

namespace week4AlgsnDataz
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkList testList = new LinkList();

            testList.AddItem(5);
            testList.AddItem(10);
            testList.AddItem(10);
            testList.AddItem(20);
            testList.AddItem(10);
            testList.AddItem(10);


            if (testList.IsPresentItem(5))
            {
                Console.WriteLine("yaaaaaasssss");
            }
            else
            {
                Console.WriteLine("nooooooooo");
            }
            Console.ReadKey();

            testList.DisplayItems();

            testList.RemoveItem(10);
            Console.WriteLine("remove items containing 10");

            testList.DisplayItems();

            Console.ReadKey();
        }
    }
}
