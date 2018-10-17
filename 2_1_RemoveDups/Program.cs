using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1_RemoveDups
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

            RemoveDups(unsortedList);

            WriteList(unsortedList);
        }

        //Essa solução trabalha com a restrição de não poder contar com Hashtable (que tornaria o problema muito mais fácil)
        //Essa solução tem complexidade O(n^2) de tempo e O(1) de espaço
        static void RemoveDups(LinkedList<int> list)
        { 
            LinkedListNode<int> p1 = list.First;
            LinkedListNode<int> p2 = list.Last;

            while(p1 != p2)
            {
                if(p1.Value == p2.Value)
                {
                    int value = p1.Value;
                    p1 = p1.Next;
                    p2 = list.Last;
                    list.Remove(value);                                                           
                }
                else
                {
                    p2 = p2.Previous;
                }                
            }
        }

        static void WriteList(LinkedList<int> list)
        {
            LinkedListNode<int> pointer = list.First;
            while(pointer != null)
            {
                Console.WriteLine(pointer.Value);
                pointer = pointer.Next;
            }
        }
    }
}
