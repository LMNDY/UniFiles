using System;

namespace Lab2Library
{   
    class Program
    {

        public int NoOfBooks = 8;

        static void Main(string[] args)
        {
            Book[] books = new Book[8];  //declare an array of Book

            books[0] = new Book("Moby Dick");
            books[0].Author = new Person("Herman Melville");
            books[1] = new Horror("The Creeping");
            books[2] = new Horror("IT");
            books[3] = new YoungAdult("Twilight");
            books[4] = new Classical("Emma");
            books[5] = new Fantasy("The Hobbit");
            books[6] = new Fantasy("Harry Potter and the Chamber of Secrets");
            books[6].Author = new Person("J K Rowling");
            books[7] = new YoungAdult("Host");

            LinkList testList = new LinkList();

            testList.AddItem(new Book("LOTR", "JRR Tolkien"));
            testList.AddItem(new Fantasy("LOTR2"));

            testList.DisplayItems();

            for (int i = 0; i < 7; i++)
                Console.WriteLine("{0} \n ", Book.getSummary(books[i]));
                Console.ReadKey();
        }

    }
}
