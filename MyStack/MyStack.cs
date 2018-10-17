using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStack
{
    public class MyStack<T>
    {
        internal class StackNode<T>
        {
            internal T data;
            internal StackNode<T> next;
            public StackNode(T data) { this.data = data; }
        }

        private StackNode<T> top;
        public T pop()
        {
            if (top == null) throw new Exception();
            T item = top.data;
            top = top.next;
            return item;
        }

        public void push(T item)
        {
            StackNode<T> t = new StackNode<T>(item);
            t.next = top;
            top = t;
        }

        public T peek()
        {
            if (top == null) throw new Exception();
            return top.data;
        }

        public bool isEmpty()
        {
            return top == null;
        }
    }
}
