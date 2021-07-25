using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradingApp
{
    public class BinTree<T> where T : IComparable
    {
        protected Node<T> root;
        public BinTree()  //creates an empty tree
        {
            root = null;
        }
        public BinTree(Node<T> node)  //creates a tree with node as the root
        {
            root = node;
        }

        //In Order-----------------------------------------------
        public string InOrder()
        {
            var str = "";
            inOrder(root, ref str);
            return str;
        }

        private void inOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                inOrder(tree.Left, ref buffer);
                buffer += tree.Data.ToString() + ",";
                inOrder(tree.Right, ref buffer);
            }
        }

        //Pre Order------------------------------------------------
        public string PreOrder()
        {
            var str = "";
            preOrder(root, ref str);
            return str;
        }

        private void preOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                buffer += tree.Data.ToString() + ",";
                preOrder(tree.Left, ref buffer);
                preOrder(tree.Right, ref buffer);
            }
        }

        //Post Order----------------------------------------------
        public string PostOrder()
        {
            var str = "";
            postOrder(root, ref str);
            return str;
        }

        private void postOrder(Node<T> tree, ref string buffer)
        {
            if (tree != null)
            {
                postOrder(tree.Left, ref buffer);
                postOrder(tree.Right, ref buffer);
                buffer += tree.Data.ToString() + ",";
            }
        }
        //Print out to screen -----------------------------------------
        public void DoTraversals()
        { 
            Console.WriteLine("PreOrder " + PreOrder());
            Console.WriteLine("PostOrder " + PostOrder());
            Console.WriteLine("InOrder " + InOrder());
        }
    }
}
