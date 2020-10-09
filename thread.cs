using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Multithread.cs
{
    class thread
    {
        private Action thread4;

        public thread(Action thread4)
        {
            this.thread4 = thread4;
        }

        static void thread1()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Thread 1 is Started");
                Console.WriteLine("Thread 1 is started at the position:" +  i);
            }
            Console.WriteLine();
        }

        static void thread2()
        {
            for (int i = 0; i < 15; i++)
            {
                //if(i==5)
                //{
                //    Console.WriteLine("thread 2 is sleeping foe\r 5 sec");
                    
                //}
                Console.WriteLine("Thread   2 is Started");
                Console.WriteLine("Thread 2 is started at the position:" + i);
            }
            
        }

        static void thread3()
        {
            for (int i = 0; i < 51; i++)
            {
                Console.WriteLine("Thread 3 is Started");
                Console.WriteLine("Thread 3 is started at the position:" + i);
            }
            
        }

        static void Main(string[] args)
        {
            //instatiate the methods created
            thread1();
            thread2();
            thread3();

            Console.ReadLine();
        }

        
    }
}
