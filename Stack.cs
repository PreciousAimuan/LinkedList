using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{

    public class Stack<T> : Node<T>
    {

            private int size = 0;

            public bool IsEmpty()
            {
                return NodeHead == null;
            }

            public void Push(T item)
            {
                Node<T> currentNode = new Node<T>{Tvalue = item};
                currentNode.NextNode = NodeHead; // move the prev item
                NodeHead = currentNode;  // make newvalue nodehead
                size++;
            }

            public T Pop()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Stack is empty");
                }

                T data = NodeHead.Tvalue;  //last val
                NodeHead = NodeHead.NextNode;   // move p
                size--;
                return data;
            }

            public T Peek()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Stack is empty");
                }

                Node<T> currentNode = NodeHead; //start
                T data = currentNode.Tvalue;
                return data;

        }

            public int Size()
            {
                return size;
            }

    }

}
