using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Library
{
    class Horror : Book
    {
        public Horror(string title) : base(title)
        {
            base.Author = new Person("Stephen King");
        }

    }
}
