using MyBinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2_MinimalTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 6, 10, 13, 20, 24, 40, 67};

            int min = 0;
            int max = array.Length - 1;
            int mid = min + max / 2; 

            BinaryTreeNode root = new BinaryTreeNode(array[mid]);

            var node = TransformArrayToBinaryTree(root, array, min, max, mid);
        }

        static BinaryTreeNode TransformArrayToBinaryTree(BinaryTreeNode node, int[] sortedArray, int min, int max, int mid)
        {           
            InsertLeft(node, sortedArray, min, mid);
            InsertRight(node, sortedArray, max, mid);

            return node;
        }

        static void InsertLeft(BinaryTreeNode node, int[] sortedArray, int min, int mid)
        {            
            int max = mid - 1;
            if (min == max)
            {
                node.Left = new BinaryTreeNode(sortedArray[min]);
                return;
            }                
            int newMid = (int)Math.Ceiling((double)(min + max) / 2);
            if (mid != newMid)
            {
                node.Left = new BinaryTreeNode(sortedArray[newMid]);
                TransformArrayToBinaryTree(node.Left, sortedArray, min, max, newMid);
            }             
        }

        static void InsertRight(BinaryTreeNode node, int[] sortedArray, int max, int mid)
        {
            int min = mid + 1;
            if (min == max)
            {
                node.Right = new BinaryTreeNode(sortedArray[min]);
                return;
            }                
            int newMid = (int)Math.Floor((double)(min + max) / 2);
            if (mid != newMid)
            {
                node.Right = new BinaryTreeNode(sortedArray[newMid]);
                TransformArrayToBinaryTree(node.Right, sortedArray, min, max, newMid);
            }
        }
    }
}
