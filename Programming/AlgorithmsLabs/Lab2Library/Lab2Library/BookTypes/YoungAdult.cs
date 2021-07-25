using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2Library
{
    class YoungAdult : Book
    {

        public YoungAdult(string title) : base(title)
        {
            base.Author = new Person("Stephanie Mayer");
        }
    }
}
