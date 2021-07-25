using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class LinkListGen<T> where T : IComparable
    {
        private LinkGen<T> list;
        private T item;

        public LinkListGen()
        {

        }

        public LinkListGen(T item)
        {
            this.item = item;
            this.list = null;
        }

        public LinkListGen(T item, LinkGen<T> list)
        {
            this.item = item;
            this.list = list;
        }


        public void AddItem(T item)
        {
            list = new LinkGen<T>(item, list);
        }

        public string DisplayList()
        {
            LinkGen<T> temp = list;
            string buffer = "";
            while (temp != null) // move one link and add head to the buffer
            {
                Console.WriteLine(temp.Data);
                temp = temp.Next;
            }
            return buffer;
        }

        public int NumberOfItems()
        {
            LinkGen<T> temp = list;
            int count = 0;
            while (temp != null) // move one link and add 1 to count
            {
                temp = temp.Next;
                count += 1;
            }
            return count;
        }

        public bool IsPresentItem(T item)
        {
            LinkGen<T> temp = list;
            while (temp != null) // move one link and add 1 to count
            {
                if (item.CompareTo(temp.Data) < 0)
                {
                    return true;
                }
                temp = temp.Next;

            }
            return false;
        }

        public void RemoveItem(T item)
        {
            LinkGen<T> temp = list;
            LinkGen<T> temp2 = list;
            int count = 0;

            while (temp != null)
            {
                if (item.CompareTo(list.Data) == 0 && list != null)
                {
                    temp = list.Next;
                    list = list.Next;
                }
                if (item.CompareTo(temp.Data) == 0)
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

        public void AppendItem(T item)
        {
            LinkGen<T> temp = list;

            if (temp == null)
                list = new LinkGen<T>(item);
            else
            {
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = new LinkGen<T>(item);
            }
        }

        public void Concat(LinkListGen<T> list2)
        {
            LinkGen<T> temp = list2.list;
            while (temp != null)
            {
                AppendItem(temp.Data);
                temp = temp.Next;
            }
        }

        public void Copy(LinkListGen<T> list2)
        {
            LinkListGen<T> newList = new LinkListGen<T>();
            newList.Concat(list2);
            list = newList.list;
        }

        public void InsertInOrder(T item)
        {
            LinkGen<T> temp = list;
            LinkGen<T> temp2 = list;
            bool inserted = false;

            if (temp == null)
            {
                AddItem(item);
            }
            else
            {
                while (temp.Next != null && inserted == false)
                {
                    if (item.CompareTo(temp.Next.Data) < 0)
                    {
                        temp.Next = new LinkGen<T>(item, temp2.Next);
                        inserted = true;
                    }
                        temp = temp.Next;
                        temp2 = temp2.Next;
                }
                if (inserted == false)
                {
                    AppendItem(item);
                }
            }
        }

        public void Sort()
        {
            LinkListGen<T> newList = new LinkListGen<T>();
            while (list != null)
            {
                newList.InsertInOrder(list.Data);
                list = list.Next;
            }
            list = newList.list;
        }
    }
}


