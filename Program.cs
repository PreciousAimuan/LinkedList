using System;
using System.Collections.Generic;

namespace LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            var linkedListMethod = new LinkedListMethod<int>();

            Console.WriteLine("Adding Items...");

            linkedListMethod.AddItem(5);
            linkedListMethod.AddItem(1);
            linkedListMethod.AddItem(2);
            linkedListMethod.AddItem(3);

            Console.WriteLine("Linked List values: ");
            linkedListMethod.DisplayList();

            Console.WriteLine("Removing Linked List values: ");
            linkedListMethod.Remove(5);
            linkedListMethod.DisplayList();

            linkedListMethod.Remove(3);
            linkedListMethod.DisplayList();

            Console.WriteLine("Check List value: ");
            Console.WriteLine(linkedListMethod.Check(5));

            Console.Write("Check Index of value: ");
            Console.WriteLine(linkedListMethod.IndexOf(2)); // 2 is at the 1 index.
            Console.WriteLine();

            //Entering Stacks..
            var stack = new Stack<int>();
            Console.WriteLine("For Stacks");
            Console.WriteLine("Is the stack empty? " + stack.IsEmpty()); // Output: True
           // Console.WriteLine();
            Console.WriteLine("..Pushing Items into Stacks..");
           // Console.WriteLine();
            stack.Push(4);
            stack.Push(5);
            stack.Push(1);
            stack.Push(2);
            stack.Push(6);
            Console.WriteLine("Is the stack empty? " + stack.IsEmpty()); // Output: False
            Console.Write("Peek into stack: ");
            Console.WriteLine(stack.Peek());
            Console.WriteLine("Number of elements in stack: " + stack.Size());
            Console.WriteLine("Pop a value..");
            stack.Pop();
            Console.WriteLine("Number of elements in stack: " + stack.Size());

            //Entering Queues..
            Console.WriteLine();
            Console.WriteLine("For Queues");
            var queue = new Queue<int>();
            Console.WriteLine("Is the queue empty? " + queue.IsEmpty()); // Output: True
            Console.WriteLine("..Enqueuing..");
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(1);   
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine("Is the queue empty? " + queue.IsEmpty()); // Output: False
            Console.WriteLine("Number of elements in queue: " + queue.Size());
            Console.WriteLine("..Dequeue once..");
            Console.WriteLine("Dequeued number: " + queue.Dequeue());
            Console.WriteLine("Number of elements in queue: " + queue.Size());

        }
    }
}
