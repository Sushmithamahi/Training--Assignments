using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpQueue
{
    class Queue
    {
        static void Main(string[] args)
        {
            Queue<int> Myqueue = new Queue<int>();// creation of queue object
            Myqueue.Enqueue(2);
            Myqueue.Enqueue(4);
            Myqueue.Enqueue(6);
            Myqueue.Enqueue(8);
            Myqueue.Enqueue(10);
            Myqueue.Enqueue(12);
            Myqueue.Enqueue(14);
            Myqueue.Enqueue(16);
            Myqueue.Enqueue(18);

            foreach(int DXC in Myqueue)
            {
                Console.WriteLine("queue elements are:" + DXC);
            }
            //one
            Console.WriteLine("after dequeue:" + Myqueue.Dequeue());
            Console.WriteLine("peek ele of dequeue:" + Myqueue.Peek());
            Console.WriteLine("current ele in queue:" + Myqueue.Count());
          
            
            Console.WriteLine("Myqueue contains:",Myqueue.Contains(10));

            //2nd time
            Console.WriteLine("after dequeue:" + Myqueue.Dequeue());

            foreach (int DXC in Myqueue)
            {
                Console.WriteLine("queue elements are:" + DXC);
            }
            Console.WriteLine("peek ele of dequeue:" + Myqueue.Peek());
            Console.WriteLine("current ele in queue:" + Myqueue.Count());

            //3rd time
            Console.WriteLine("after dequeue:" + Myqueue.Dequeue());

            foreach (int DXC in Myqueue)
            {
                Console.WriteLine("queue elements are:" + DXC);
            }
            Console.WriteLine("peek ele of dequeue:" + Myqueue.Peek());
            Console.WriteLine("current ele in queue:" + Myqueue.Count());

            //4th time
            Console.WriteLine("after dequeue:" + Myqueue.Dequeue());

            foreach (int DXC in Myqueue)
            {
                Console.WriteLine("queue elements are:" + DXC);
            }
            Console.WriteLine("peek ele of dequeue:" + Myqueue.Peek());
            Console.WriteLine("current ele in queue:" + Myqueue.Count());

            //5th time
            Console.WriteLine("after dequeue:" + Myqueue.Dequeue());

            foreach (int DXC in Myqueue)
            {
                Console.WriteLine("queue elements are:" + DXC);
            }
            Console.WriteLine("peek ele of dequeue:" + Myqueue.Peek());
            Console.WriteLine("current ele in queue:" + Myqueue.Count());

            //6th time
            Console.WriteLine("after dequeue:" + Myqueue.Dequeue());

            foreach (int DXC in Myqueue)
            {
                Console.WriteLine("queue elements are:" + DXC);
            }
            Console.WriteLine("peek ele of dequeue:" + Myqueue.Peek());
            Console.WriteLine("current ele in queue:" + Myqueue.Count());


            Console.ReadLine();
        }
    }
}
