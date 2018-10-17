using MyBinaryTree;
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
            BinaryTreeNode root = new BinaryTreeNode(1);
            var left1 = root.Left = new BinaryTreeNode(2);
            var right1 = root.Right = new BinaryTreeNode(3);
            var left2 = left1.Left = new BinaryTreeNode(4);
            var right2 = left1.Right = new BinaryTreeNode(5);

            Console.WriteLine("In Order");
            PrintInOrderTraversal(root);
            Console.WriteLine("Pre Order");
            PrintPreOrderTraversal(root);
            Console.WriteLine("Post Order");
            PrintPostOrderTraversal(root);
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
    }
}
