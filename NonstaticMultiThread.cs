using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Multithread.cs
{
    public class NonstaticMultiThread
    {
        //Non_static return methods

        public void Thread4()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }


       public static void Main(string[] args)
        {
            NonstaticMultiThread mt = new NonstaticMultiThread();
            Thread t1 = new Thread(new ThreadStart(mt.Thread4));
            Thread t2 = new Thread(new ThreadStart(mt.Thread4));
            t1.Start();
            t2.Start();
            Console.ReadLine();
        }
    }
    
}
