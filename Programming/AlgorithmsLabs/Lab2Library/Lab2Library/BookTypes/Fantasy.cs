using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Library
{
    class Fantasy : Book
    {
        public Fantasy(string title) : base(title)
        {
            base.Author = new Person("JRR Tolkien");
        }
    }
}
