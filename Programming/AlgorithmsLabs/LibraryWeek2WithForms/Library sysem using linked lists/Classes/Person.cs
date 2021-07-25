using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_sysem_using_linked_lists
{
    class Person : IComparable
    {
        private int age;
        private string name;

        //constructor with one arguement just for name
        public Person(string name)
        {
            this.name = name;
            age = 18; //default age
        }

        //constructor with 2 arguements for name and age
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //property for name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //property for age
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //implementation of CompareTo for IComparable
        public int CompareTo(object obj)
        {
            Person other = (Person)obj;
            return Name.CompareTo(other.Name);
        }
    }
}
