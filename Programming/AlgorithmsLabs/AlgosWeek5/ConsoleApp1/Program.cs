using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkListGen<int> newList = new LinkListGen<int>();
            LinkListGen<int> newList2 = new LinkListGen<int>();
            LinkListGen<int> newList3 = new LinkListGen<int>();
            LinkListGen<int> newList4 = new LinkListGen<int>();
            LinkListGen<int> newList5 = new LinkListGen<int>();
            LinkListGen<int> newList6 = new LinkListGen<int>();

            newList.AddItem(5);
            newList.AddItem(10);
            newList.AddItem(15);
            newList.AddItem(20);

            newList2.AddItem(55);
            newList2.AddItem(65);
            newList2.AddItem(75);
            newList2.AddItem(85);

            newList3.AddItem(100);
            newList3.AddItem(200);
            newList3.AddItem(300);
            newList3.AddItem(400);

            newList4.AddItem(450);
            newList4.AddItem(350);
            newList4.AddItem(250);
            newList4.AddItem(150);

            newList5.AddItem(25);
            newList5.AddItem(900);
            newList5.AddItem(345);
            newList5.AddItem(9);

            Console.WriteLine("List 1");
            newList.DisplayList();
            Console.WriteLine(" ");

            Console.WriteLine("List 2");
            newList2.DisplayList();
            Console.WriteLine(" ");

            Console.WriteLine("List 3");
            newList3.DisplayList();
            Console.WriteLine(" ");

            Console.WriteLine("concat list 1 with list 2");
            newList.Concat(newList2);
            Console.WriteLine("display list 1");
            newList.DisplayList();
            Console.WriteLine("display list 2");
            newList2.DisplayList();

            Console.WriteLine("copy list 2 to list 1");
            newList.Copy(newList2);

            Console.WriteLine("display list 1");
            newList.DisplayList();

            Console.WriteLine("insert 275 in order");
            newList4.InsertInOrder(275);
            Console.WriteLine("display list 4");
            newList4.DisplayList();
            newList4.InsertInOrder(455);
            Console.WriteLine(" ");
            Console.WriteLine("display list 4 after adding 455 into order");
            newList4.DisplayList();
            Console.WriteLine(" ");

            newList6.InsertInOrder(10);
            newList6.DisplayList();

            Console.WriteLine(" ");

            Console.WriteLine("display list 5");
            newList5.DisplayList();
            Console.WriteLine(" ");
            Console.WriteLine("sort and display list 5");
            newList5.Sort();
            newList5.DisplayList();

            Console.ReadKey();
        }
    }
}
