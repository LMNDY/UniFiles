using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgosWeek9
{
    class BSTree<T> : BinTree<T> where T : IComparable 
    {  //root declared as protected in Parent Class – Binary Tree
        public BSTree()
        {
            root = null;
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
                tree = new Node<T>(item);

            else if (item.CompareTo(tree.Data) < 0)
                insertItem(item, ref tree.Left);

            else if (item.CompareTo(tree.Data) > 0)
                insertItem(item, ref tree.Right);
        }

        public void InsertItem(T item)
        { insertItem(item, ref root); }

        public int Height()
        //Return the max level of the tree
        {

        }

        public int Count()
        //Return the number of nodes in the tree
        {

        }


        public Boolean Contains(T item)
        //Return true if the item is contained in the BSTree, false 	  //otherwise.
        {

        }


    }

}
