using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingApp
{
    public class BSTree<T> : BinTree<T> where T : IComparable
    {
        //Tree Height---------------------------------------------
        public int TreeHeight()
        {
            return treeHeight(root);
        }

        protected int treeHeight(Node<T> tree)
        {
            if (tree == null)
            {
                return 0;
            }
            else
            {
                return 1 + Math.Max(treeHeight(tree.Left), treeHeight(tree.Right));
            }
        }

        //Node Count----------------------------------------------
        public int NodeCount()
        {
            return nodeCount(root);
        }

        private int nodeCount(Node<T> tree)
        {
            if (tree == null) return 0;
            return (1 + (nodeCount(tree.Left)) + (nodeCount(tree.Right)));

        }

        //Contains -----------------------------------------------
        public Boolean Contains(T item)
        {
            return contains(root, item);
        }


        private Boolean contains(Node<T> root, T item)
        {
            if (root != null)
            {
                if (item.CompareTo(root.Data) == 0)
                {
                    return true;
                }
                else if ((item.CompareTo(root.Data) < 0) | (item.CompareTo(root.Data) > 0))
                {

                    return contains(root.Left, item) | contains(root.Right, item);
                }
            }
            return false;
        }
        //Insert Item -------------------------------------------
        public void InsertItem(T item)
        {
            insertItem(item, ref root);
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

        //Find min in tree------------------------------------------

        public T minTree(Node<T> tree)
        {
            if (tree.Left == null)
            {
                return tree.Data;
            }
            else return minTree(tree.Left);
        }

        //Remove Item ----------------------------------------------
        public void RemoveItem(String item) //covered in lecture 16
        {
            removeItem(ref root, item);
        }


        public void removeItem(ref Node<T> root, String item)
        {
            int caseSwich = 0;
            if (root != null)
            {
                removeItem(ref root.Left, item);
                removeItem(ref root.Right, item);
                Console.WriteLine(root.Data + "  " + item);
                if (root.Data.Equals(item)) //check first node
                {
                    Console.WriteLine("Found it");
                    if (root.Left == null && root.Right == null) { caseSwich = 1; };
                    if (root.Left != null && root.Right == null) { caseSwich = 2; };
                    if (root.Left == null && root.Right != null) { caseSwich = 3; };
                    if (root.Left != null && root.Right != null) { caseSwich = 4; };
                }

                switch (caseSwich)
                {
                    case 1:
                        root = null;
                        break;
                    case 2:
                        root = root.Left;
                        break;
                    case 3:
                        root = root.Right;
                        break;
                    case 4:
                        T tree = minTree(root.Right);
                        root.Data = tree;
                        removeItem(ref root.Right, root.Data.ToString());
                        break;
                }
            }
        }
    }
}
