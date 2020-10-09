using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multithread.cs
{
    class NonstaticsingleThread
    {
        //Non_static return methods
        static string Threads1()
        {
            return "This is NonstaticsingleThread1";
        }

        static string Threads2()
        {
            return "This is NonstaticsingleThread2";
        }

        static string Threads3()
        {
            return "This is NonstaticsingleThread3";
        }
        static void Main(string[]args)
        {
            //instantiation of 1.non-static return methods by creating new variable

            string res1 = Threads1();
            Console.WriteLine(res1);
            Console.WriteLine();

            //instantiation of 2.non-static return methods by creating new variable

            string res2 = Threads2();
            Console.WriteLine(res2);
            Console.WriteLine();

            //instantiation of 3.non-static return methods by creating new variable
            string res3 = Threads3();
            Console.WriteLine(res3);

            Console.ReadLine();



        }
    }
}
