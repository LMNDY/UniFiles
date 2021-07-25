using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosWeek8
{
    class Program
    {
        static void Main(string[] args)
        {
            Node<int>[] a = {new Node<int>(1), new Node<int>(2), new Node<int>(3), new Node<int>(4), new Node<int>(5),
                            new Node<int>(6), new Node<int>(7), new Node<int>(8), new Node<int>(9), new Node<int>(10) };

            a[0].Left = a[1];
            a[0].Right = a[2];
            a[1].Left = a[3];
            a[1].Right = a[4];
            a[2].Left = a[5];
            a[2].Right = a[6];
            a[4].Right = a[7];
            a[7].Left = a[8];
            a[7].Right = a[9];

            BinTree<int> bt = new BinTree<int>(a[0]);

            bt.DoTraversals();

            Console.ReadLine();
        }
    }
}
