using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BSTree<T> : BinTree<T> where T : IComparable
    {
        // Height returns the max level of the nodes in the BST
        public int Height()
        {
            return height(root);
        }

        public int height(Node<T> tree)
        {
            if (tree == null) return 0;

            else
                return 1 + Math.Max(height(tree.Left), height(tree.Right));
        }
        // End of the BST Height


        // Count method to return the # of nodes in the BST
        public int CountBST()
        {
            return countBST(root);
        }

        private int countBST(Node<T> tree)
        {
            if (tree == null) return 0;
            return (1 + (countBST(tree.Left)) + (countBST(tree.Right)));
        }
        // End of the BST Node count

        // Contains returns true if the item is contained in the BST, otherwise false
        public Boolean Contains(T item)
        {
            return contains(item, ref root);
        }

        private Boolean contains(T item, ref Node<T> root)
        {
            if (root != null)
            {
                if (item.CompareTo(root.Data) == 0)
                {
                    return true;
                }
                else if (item.CompareTo(root.Data) < 0 | (item.CompareTo(root.Data) > 0))
                {
                    return contains(item, ref root.Left) | contains(item, ref root.Right);
                }
            }
            return false;
        }
        // End of - it is contained in the BST

        public void RemoveItem(T item )
        {
            removeItem(item, ref root);
        }


        // Delete a node from the BST
        public void removeItem(T item, ref Node<T> tree)
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
                Console.WriteLine("The item does not exist in the tree");
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
        // End deleting a node 



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

    }
}
