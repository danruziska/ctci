using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_DeleteMiddleNode
{
    public class MyLinkedList
    {
        public class Node
        {
            // link to next Node in list
            public Node next = null;
            // value of this Node
            public object data;

            public Node(object data)
            {
                this.data = data;
            }
        }

        public Node Append(object value)
        {
            Node n = new Node(value);
            if (root == null)
                root = n;
            else
                Last.next = n;

            return n;                
        }

        private Node root = null;

        public Node First { get { return root; } }

        public Node Last
        {
            get
            {
                Node curr = root;
                if (curr == null)
                    return null;
                while (curr.next != null)
                    curr = curr.next;
                return curr;
            }
        }
    }
}
