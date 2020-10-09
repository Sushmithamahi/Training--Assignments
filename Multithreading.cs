using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithread.cs
{
    class Multithreading
    {
        static void Thread1  ()
        {
            for(int i=1;i<15;i++)
            {
                Console.WriteLine("thread 1 is started:" +i);
            }
        }

        static void Thread2()
        {
            for (int i = 1; i < 15; i++)
            {
                if (i == 10)
                {
                    Thread.Sleep(10000);
                    Console.WriteLine("thread 2 is sleeping for 10 sec");
                }
                Console.WriteLine("thread 2 is started:" +i);
            }
        }

        static void Thread3()
        {
            
            for (int i = 1; i < 15; i++)
            {
                if(i==10)
                {
                    Thread.Sleep(10000);
                    Console.WriteLine("thread 3 is sleeping for 10 sec");
                }
                Console.WriteLine("thread 3 is started:" +i);
            }
        }

        static void Main(string[]args)
        {
            //creating child threads class w.r.t methods involved

            //one main thraed and 3 child threads
            Thread t1 = new Thread(Thread1);
            Thread t2 = new Thread(Thread2);
            Thread t3 = new Thread(Thread3);

            t1.Start();t2.Start();t3.Start();

            Console.ReadLine();

        }
    }
}
