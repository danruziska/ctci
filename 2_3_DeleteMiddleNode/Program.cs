using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _2_3_DeleteMiddleNode.MyLinkedList;

namespace _2_3_DeleteMiddleNode
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList list = new MyLinkedList();
            list.Append(1);
            list.Append(2);
            Node n = list.Append(3);
            list.Append(4);
            list.Append(5);

            DeleteMiddleNode(n);
        }

        static void DeleteMiddleNode(Node node)
        {
            node.data = node.next.data;
            node.next = node.next.next;
        }
    }
}
