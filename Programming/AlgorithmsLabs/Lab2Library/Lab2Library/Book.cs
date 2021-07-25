using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Library
{
    class Book : IComparable
    {
        public string Title;
        public Person Author;

        // constructor with 1 arguement just for title
        public Book(string title)
        {
            Author = new Person("undefined");
            this.Title = title;
        }

        //constructor with 2 arguements for title and author anem
        public Book(string title, string newAuthor)
        {
            Author = new Person(newAuthor);
            this.Title = title;
        }

        public string AuthorName
        {
            get { return Author.Name; }
            set { Author.Name = value; }
        }

        public int CompareTo(object obj)
        {
            return ((IComparable)AuthorName).CompareTo(obj);
        }

        internal static string getSummary(Book book)
        {
            string summary = book.Title + " by " + book.Author.Name + " age " + book.Author.Age;

            return summary;
        }
    }
}
