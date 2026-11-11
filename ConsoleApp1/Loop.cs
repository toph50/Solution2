using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Loop<T>
    {
        static Queue<T> queue;
        public static void Initialize(IEnumerable<T> items)
        {
            queue = new Queue<T>(items);
        }
        public static T Value
        {
            get
            {
                if (queue == null || queue.Count == 0)
                {
                    throw new InvalidOperationException("Queue is not initialized.");
                }
                queue.Enqueue(queue.Peek());
                return queue.Dequeue();
            }
        }
    }
}
