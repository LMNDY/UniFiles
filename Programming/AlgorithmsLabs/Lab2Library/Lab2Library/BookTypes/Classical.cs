using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Library
{
    class Classical : Book
    {
        public Classical(string title) : base(title)
        {
            base.Author = new Person("Jane Austen");
        }
    }
}
