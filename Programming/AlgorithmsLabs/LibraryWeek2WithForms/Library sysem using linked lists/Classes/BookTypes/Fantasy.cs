using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_sysem_using_linked_lists.Classes.BookTypes
{
    class Fantasy : Book
    {
        public Fantasy(string title) : base(title)
        {
            base.Author = new Person("Undefined");
        }

        public Fantasy(string title, string author) : base(title, author)
        {
            
        }
    }
}
