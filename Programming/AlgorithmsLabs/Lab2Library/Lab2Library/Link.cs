using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Library
{
    class Link
    {
        private Book book;
        private Link next;

        public Link(Book item) //constructor with an item
        {
            book = item;
            next = null;
        }

        public Link(Book item, Link list) //constructor with item and list
        {
            book = item;
            next = list;
        }

        public Book Book //property for data
        {
            set { this.book = value; }
            get { return this.book; }
        }

        public Link Next //property for next
        {
            set { this.next = value; }
            get { return this.next; }
        }
    }
}
