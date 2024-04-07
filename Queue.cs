using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Queue<T> : Node<T>
    {
            private int size = 0;

            public bool IsEmpty()
            {
                return size == 0;
            }

            public void Enqueue(T item)
            {
                Node<T> node = new Node<T>{Tvalue = item};
                if (NodeTail == null)
                {
                    NodeHead = node;
                    NodeTail = node; // make head&tail node
                }
                else
                {
                    NodeTail.NextNode = node;
                    NodeTail = node;
                }
                size++;
            }

            public T Dequeue()
            {
                if (IsEmpty())
                {
                    throw new InvalidOperationException("Queue is empty");
                }

                T data = NodeHead.Tvalue;  
                NodeHead = NodeHead.NextNode; 
                if (NodeHead == null)
                {
                    NodeTail = null; // nodehead == nodetail
                }
                size--;
                return data;
            }

            public int Size()
            {
                return size;
            }
        
    }
}
