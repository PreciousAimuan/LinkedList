using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node<T>
    {
        public T Tvalue { get; set; }

        public Node<T> NextNode { get; set; }

        public Node<T> NodeHead { get; set; }

        public Node<T> NodeTail { get; set; }
    }
}
