using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithread.cs
{
    class jointhread
    {
        static void thread1()
        {
            for(int i=1;i<15;i++)
            {
                Console.WriteLine("thread1 is stred" + i);
            }
        }
        static void Main(string[]args)
        {
            Console.WriteLine("main thread started");
            thread t1 = new thread(thread1);
            Console.ReadLine();
        }

    }
}
