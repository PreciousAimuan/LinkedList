using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListMethod<T> : Node<T>
    {
        private int ListSize;

        public int AddItem(T Rvalue)
        {
            var node = new Node<T> {Tvalue = Rvalue};
            if (NodeHead == null)
            {
                NodeHead = node;
            }
            else
            {
                var currentNode = NodeHead;
                while (currentNode.NextNode != null)
                {
                    currentNode = currentNode.NextNode;
                }
                currentNode.NextNode = node;

            }

            ListSize++;
            return ListSize;
        }

        public void DisplayList()
        {
            var currentNode = NodeHead;

                // Traverse the list and print the data of each node
                while (currentNode != null)
            {
                Console.Write(currentNode.Tvalue + " ");
                currentNode = currentNode.NextNode; // Move to the next node
            }

            Console.WriteLine();

        }

        public bool Check(T Rvalue)
        {
            var currentNode = NodeHead;

            while (currentNode != null)
            {
                if (currentNode.Tvalue.Equals(Rvalue))
                {
                    return true;
                }

                currentNode = currentNode.NextNode; 
            }


            return false;
        }

        public bool Remove(T Rvalue)
        {
            if (NodeHead == null)
            {
                return false;
            }

            // If the item to be removed is at the head of the list
            if (NodeHead.Tvalue.Equals(Rvalue))
            {
                NodeHead = NodeHead.NextNode; // Update the head to the next node, else
                return true;
            }

            var currentNode = NodeHead;

            while (currentNode.NextNode != null && !currentNode.NextNode.Tvalue.Equals(Rvalue)) 
            {
                currentNode = currentNode.NextNode;
            }

            // If the item is found in the middle of the list
            if (currentNode.NextNode != null)
            {
                currentNode.NextNode = currentNode.NextNode.NextNode; // Skip the node to be removed
                return true;
            }

            return false; // Item not found in the list
        }

        public int IndexOf(T Rvalue)
        {
            int index = 0;

            var currentNode = NodeHead; 
            int currentIndex = 0;

            while (currentNode != null)
            {
                if (currentNode.Tvalue.Equals(Rvalue))
                {
                    index = currentIndex; // Update the index when the item is found
                    return index;
                }

                currentNode = currentNode.NextNode; // Move to the next node
                currentIndex++;
            }

            return -1;
        }

    }
}
