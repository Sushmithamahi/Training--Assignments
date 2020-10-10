using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Deadlock
{
    class threadlock
    {
       
            public void Display()
            {
               lock (this )//it will run both the threads as one 
               {
                Console.WriteLine("locks");
                Thread.Sleep(5000);

                Console.WriteLine("deadlocks");
               }

            }
        
       
            
        
        static void Main(string[] args)
        {
                      
            threadlock obj = new threadlock();
            //instatiated the thread with method refernece
            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            Thread t3 = new Thread(obj.Display);
            t1.Start(); t2.Start();t3.Start();
            Console.ReadLine();
        }
    }
}
