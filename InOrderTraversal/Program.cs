using MyBinaryTree;
using MyPrefixTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            //BinaryTreeNode root = new BinaryTreeNode(1);
            //var left1 = root.Left = new BinaryTreeNode(2);
            //var right1 = root.Right = new BinaryTreeNode(3);
            //var left2 = left1.Left = new BinaryTreeNode(4);
            //var right2 = left1.Right = new BinaryTreeNode(5);

            //Console.WriteLine("In Order");
            //PrintInOrderTraversal(root);
            //Console.WriteLine("Pre Order");
            //PrintPreOrderTraversal(root);
            //Console.WriteLine("Post Order");
            //PrintPostOrderTraversal(root);


            BinaryTreeNode root = new BinaryTreeNode(1);
            var left1 = root.Left = new BinaryTreeNode(2);
            var right1 = root.Right = new BinaryTreeNode(3);
            var left2 = left1.Left = new BinaryTreeNode(4);
            var right2 = left1.Right = new BinaryTreeNode(5);
            var right3 = right1.Right = new BinaryTreeNode(6);
            var right4 = right3.Right = new BinaryTreeNode(7);
            int height = getMaxHeight(root, 0);
            Console.WriteLine(height);
        }

        static int[] contacts(string[][] queries)
        {
            List<int> countList = new List<int>();
            Trie tree = new Trie();
            for (int i = 0; i < queries.Length; i++)
            {                
                string[] internalQueries = queries[i];

                string command = internalQueries[0];
                string parameter = internalQueries[1];
                if (command == "add")
                {
                    tree.add(parameter);
                }
                else
                {
                    var count = tree.find(parameter);
                    countList.Add(count);
                }
            }
            return countList.ToArray();
        }

        static void PrintInOrderTraversal(BinaryTreeNode node)
        {
            if (node == null)
                return;

            PrintInOrderTraversal(node.Left);
            Console.WriteLine(node.Value);
            PrintInOrderTraversal(node.Right);
        }

        static void PrintPreOrderTraversal(BinaryTreeNode node)
        {
            if (node == null)
                return;            

            Console.WriteLine(node.Value);
            PrintPreOrderTraversal(node.Left);            
            PrintPreOrderTraversal(node.Right);
        }

        static void PrintPostOrderTraversal(BinaryTreeNode node)
        {
            if (node == null)
                return;

            PrintPostOrderTraversal(node.Left);
            PrintPostOrderTraversal(node.Right);
            Console.WriteLine(node.Value);
        }

        static int getMaxHeight(BinaryTreeNode node, int height)
        {
            int max = height;
            if (node == null || (node.Left == null && node.Right == null))
                return height;

            int newHeight = ++height;
            int leftHeight = getMaxHeight(node.Left, newHeight);
            int rightHeight = getMaxHeight(node.Right, newHeight);

            if (leftHeight > max)
                max = leftHeight;
            if (rightHeight > max)
                max = rightHeight;

            return max;
        }
    }
}
