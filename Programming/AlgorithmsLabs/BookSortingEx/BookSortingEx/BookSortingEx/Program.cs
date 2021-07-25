using System;
using System.Collections.Generic;
using System.Text;

namespace BookSortingEx
{
    class Program
    {

        static void swap<T>(ref T x, ref T y)
        {
          //swapcount++;
            T temp = x;
            x = y;
            y = temp;
        }


        static void printArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + ",");
            }
            Console.WriteLine();
        }

        static bool IsInOrder<T>(T[] a) where T : IComparable
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i].CompareTo(a[i + 1]) > 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {

            string[] array1 = { "Fred", "Zoe", "Angela", "Umbrella", "Ben" };
            string[] titles = {"Writing Solid Code",
                "Objects First","Programming Gems",
                "Head First Java","The C Programming Language",
                "Mythical Man Month","The Art of Programming",
                "Coding Complete","Design Patterns", 
                "Problem Solving in Java"};
            string[] authors ={ "Maguire", "Kolling", "Bentley", "Sierra", "Richie", "Brooks", "Knuth", "McConnal", "Gamma", "Weiss" };
            string[] isbns = { "948343", "849328493", "38948932", "394834342", "983492389", "84928334", "4839455", "21331322", "348923948", "43893284", "9483294", "9823943" };

            Book[] library = new Book[10];

            for (int i = 0; i < library.Length; i++)
            {
                library[i] = new Book(isbns[i], titles[i], authors[i]);
            }

            foreach (Book book in library)
            {
                Console.WriteLine(" {0} ", book);
            }
            Console.WriteLine();
            SelectionSort(library);

            foreach (Book book in library)
            {
                Console.WriteLine(" {0} ", book);
            }
            Console.WriteLine();

            QuickSort(array1, 0, array1.Length-1);

            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);
            Console.WriteLine(array1[3]);
            Console.WriteLine(array1[4]);

            Console.ReadKey();

        }

        private static void SelectionSort(Book[] library)
        {
            for (int i = 0; i < library.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < library.Length; j++)
                {
                    if (library[j].CompareTo(library[smallest]) < 0)
                        smallest = j;
                }
                swap(ref library[i], ref library[smallest]);
            }
        }

        static private T[] QuickSort<T>(T[] items, int left, int right) where T : IComparable<T>
        {
            int i, j; i = left; j = right;
            T pivot = items[left];
            while (i <= j)
            {
                for (; (items[i].CompareTo(pivot) < 0) && (i < right); i++) ;
                for (; (items[j].CompareTo(pivot) > 0) && (j > left); j--) ;
                if (i <= j) swap(ref items[i++], ref items[j--]);
            }
            if (left < j) QuickSort(items, left, j);
            if (i < right) QuickSort(items, i, right);
            return items;
        }
    }
}
