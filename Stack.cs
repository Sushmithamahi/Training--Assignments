using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpstack
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack<int> Mystack = new Stack<int>();//creation of stack
            Mystack.Push(2);//push takes one parameter or argument
            Mystack.Push(4);
            Mystack.Push(6);//accessing ele within my stack
            Mystack.Push(8);
            Mystack.Push(10);
            Mystack.Push(12);
            Mystack.Push(14);
            Mystack.Push(16);
            Mystack.Push(18);
            Mystack.Push(20);
            
            foreach(int stack in Mystack)
            {
                Console.WriteLine("the element of Mystack are:{0}", stack);
               
            }

            Console.WriteLine("elements after applying pop:",Mystack.Pop());//1st time
            Console.WriteLine("elements after applying pop 2times:", Mystack.Pop());//2nd time
            foreach (int stack in Mystack)
            {
                Console.WriteLine("the element of Mystack are:{0}", stack);
                
            }
            Console.WriteLine(" the peek ele of stack is :" + Mystack.Peek());// to find topmost ele of mystack



            Console.WriteLine("elements after applying pop 3times:", Mystack.Pop());//3rd time
            foreach (int stack in Mystack)// to retrieve elements in mystack after 3 times pop
            {
                Console.WriteLine("the element of Mystack are:{0}", stack);
            }
                Console.WriteLine(" the peek ele of stack is :" + Mystack.Peek());// to find topmost ele of mystack
            

            Console.WriteLine("elements after applying pop 4 times:", Mystack.Pop());//4th time
            foreach (int stack in Mystack)//to retrieve elements in mystack after 4 times pop
            {
                Console.WriteLine("the element of Mystack are:{0}", stack);
            }
                Console.WriteLine(" the peek ele of stack is :" + Mystack.Peek());// to find topmost ele of mystack
            

            Console.WriteLine("elements after applying pop 5 times:", Mystack.Pop());//5th time
            foreach (int stack in Mystack)// to retrieve elements in mystack after 5 times pop
            {
                Console.WriteLine("the element of Mystack are:{0}", stack);
            }
                Console.WriteLine(" the peek ele of stack is :" + Mystack.Peek());// to find topmost ele of mystack
            

            Console.WriteLine("elements after applying pop 6 times:", Mystack.Pop());//6th time    
            foreach (int stack in Mystack)// to retrieve elements in mystack after 6 times pop
            {
                Console.WriteLine("the element of Mystack are:{0}", stack);
            }
                Console.WriteLine(" the peek ele of stack is :" + Mystack.Peek());// to find topmost ele of mystack
            

            
            Console.ReadLine();
        }
    }
}
