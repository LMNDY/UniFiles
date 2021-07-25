using System;
using System.Collections.Generic;
using System.Text;

namespace week4AlgsnDataz
{
    class LinkList
    {
        private Link list = null; //default value – empty list

        public void AddItem(int item) //add item to front of list
        {
            list = new Link(item, list);
        }

        public string DisplayItems() //write items to string and return
        {
            Link temp = list;
            string buffer = "";
            while (temp != null) // move one link and add head to the buffer
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
            return buffer;
        }

        public int NumberOfItems() // returns number of items in list
        {
            Link temp = list;
            int count = 0;
            while (temp != null) // move one link and add 1 to count
            {
                temp = temp.Next;
                count += 1;
            }
            return count;
        }

        public bool IsPresentItem(int item)
        {

            Link temp = list;
            while (temp != null) // move one link and add 1 to count
            {
                if (item == temp.Data)
                {
                    return true;
                }
                temp = temp.Next;

            }
            return false;
        }

        public void RemoveItem(int item)
        {
            Link temp = list;
            Link temp2 = list;
            int count = 0;

            while (temp != null)
            {
                if (list.Data == item && list != null)
                {
                    temp = list.Next;
                    list = list.Next;
                }
                if (temp.Data == item)
                {
                    temp2.Next = temp2.Next.Next;
                    temp = temp2;
                    temp = temp.Next;
                }
                else
                {
                    temp = temp.Next;
                    if (count > 0)
                    {
                        temp2 = temp2.Next;
                    }
                }
                count++;
            }
        }
    }
}



