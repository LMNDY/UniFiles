using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_sysem_using_linked_lists.Classes.BookTypes
{
    class Classical : Book
    {
        public Classical(string title) : base(title)
        {
            base.Author = new Person("Undefined");
        }
    }
}
