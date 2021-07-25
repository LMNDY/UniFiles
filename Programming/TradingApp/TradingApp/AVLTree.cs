using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingApp
{
    public class AVLTree<T> : BSTree<T> where T : IComparable
    {
        public new void InsertItem(T item)
        {
            insertItem(item, ref root);
        }

        private void insertItem(T item, ref Node<T> tree)
        {
            if (tree == null)
            {
                tree = new Node<T>(item);
            }
            else if (item.CompareTo(tree.Data) < 0)
            {
                insertItem(item, ref tree.Left);
            }
            else if (item.CompareTo(tree.Data) > 0)
            {
                insertItem(item, ref tree.Right);
            }
            Update();
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
            Update();
        }

        public void Update()
        {
            update(ref root);
        }

        private void update(ref Node<T> tree)
        {
            tree.BalanceFactor = treeHeight(tree.Left) - treeHeight(tree.Right);

            if (tree.BalanceFactor <= -2)
            {
                rotateLeft(ref tree);
            }
            if (tree.BalanceFactor >= 2)
            {
                rotateRight(ref tree);
            }
        }

        private void rotateLeft(ref Node<T> tree)
        {
            if (tree.Right != null)
            {
                if (tree.Right.BalanceFactor > 0)  //double rotate
                {
                    rotateRight(ref tree.Right);
                }
            }

            Node<T> oldRoot = tree;
            Node<T> newRoot = oldRoot.Right;

            oldRoot.Right = newRoot.Left;
            newRoot.Left = oldRoot;
            tree = newRoot;
        }

        private void rotateRight(ref Node<T> tree)
        {
            if (tree.Right != null)
            {
                if (tree.Left.BalanceFactor > 0)
                {
                    rotateLeft(ref tree.Right);
                }
            }
            Node<T> oldRoot = tree;
            Node<T> newRoot = oldRoot.Left;

            oldRoot.Left = newRoot.Right;
            newRoot.Right = oldRoot;
            tree = newRoot;
        }
        public T GetData(String data)
        {
            return getData(data, ref root);
        }

        private T getData(String data, ref Node<T> root)
        {
            if (root != null)
            {
                if (data.ToString().CompareTo(root.Data.ToString()) == 0)
                {
                    return root.Data;
                }
                else if (data.ToString().CompareTo(root.Data.ToString()) < 0)
                {
                    return getData(data, ref root.Left);
                }
                else if (data.ToString().CompareTo(root.Data.ToString()) > 0)
                {
                    return getData(data, ref root.Right);
                }
            }
            return default(T);
        }
    }
}
