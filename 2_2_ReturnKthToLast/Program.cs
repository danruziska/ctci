using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_ReturnKthToLast
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> unsortedList = new LinkedList<int>();
            var node = unsortedList.AddFirst(2);
            var node2 = unsortedList.AddAfter(node, 4);
            var node3 = unsortedList.AddAfter(node2, 8);
            var node4 = unsortedList.AddAfter(node3, 1);
            var node5 = unsortedList.AddAfter(node4, 4);
            var node6 = unsortedList.AddAfter(node5, 2);
            var node7 = unsortedList.AddAfter(node6, 5);

            FindKthElementToLast(unsortedList, 8);
        }

        static void FindKthElementToLast(LinkedList<int> list, int k)
        {
            if (k < 0)
            {
                Console.WriteLine("Only positive numbers allowed");
                return;
            }
            
            LinkedListNode<int> pointer = list.First;
            int count = GetCountElements(list);
            if (k > count)
            {
                Console.WriteLine("The maximum number of k is " + count);
                return;
            }            
            int i = 0;
            while (count - i != k)
            {
                pointer = pointer.Next;
                i++;
            }
            if(pointer != null)
            {
                Console.WriteLine(pointer.Value);
            }
        }

        static int GetCountElements(LinkedList<int> list)
        {
            int count = 0;
            LinkedListNode<int> node = list.First;
            while (node != null)
            {
                count++;
                node = node.Next;                    
            }

            return count;
        }
    }
}
