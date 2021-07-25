using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithimsWeek9
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

        public int GetHeight()
        //Return the max level of the tree
        {
            return height(root);
        }

        int height(Node<T> node)
        {
            if (node == null) return 0;
            return (1 + Math.Max(height(node.Left), height(node.Right)));
        }

        public int GetCount()
        {
            return (Count(root));
        }

        int Count(Node<T> node)
        //Return the number of nodes in the tree
        {
            if (node == null) return 0;
            return (1 + Count(node.Left) + Count(node.Right));
        }


        public Boolean Contains(T item)
        //Return true if the item is contained in the BSTree, false 	  //otherwise.
        {
            return Contains(item, ref root);
        }

        Boolean Contains(T item, ref Node<T> node)
        {
            if (node == null)
            {
                return false;
            }

            if (node.Data.Equals(item))
            {
                return true;
            }
            if (item.CompareTo(node.Data) < 0)
            {
                return Contains(item, ref node.Left);
            }
            if (item.CompareTo(node.Data) > 0)
            {
                return Contains(item, ref node.Right);
            }
            return false;
        }

        public void RemoveItem(T item)
        {
            removeItem(item, ref root);
        }

        void removeItem(T item, ref Node<T> tree)
        {
            if (Contains(item))
            {

                if (tree == null) { }
                else
                {
                    if (item.CompareTo(tree.Data) < 0)
                    {
                        removeItem(item, ref tree.Left);
                    }
                    else if (item.CompareTo(tree.Data) > 0)
                    {
                        removeItem(item, ref tree.Right);
                    }
                    else
                    {
                        if (tree.Left == null)
                        {
                            tree = tree.Right;
                        }
                        else if (tree.Right == null)
                        {
                            tree = tree.Left;
                        }
                        else
                        {
                            T root = minItem(tree.Right);
                            tree.Data = root;
                            removeItem(tree.Data, ref tree.Right);
                        }
                    }
                }
            }
            else if (!Contains(item))
            {
                Console.WriteLine("This item does not exist");
            }
        }


        public T minItem(Node<T> tree)
        {
            if (tree.Left == null)
            {
                return tree.Data;
            }
            else return minItem(tree.Left);
        }

    }
}
