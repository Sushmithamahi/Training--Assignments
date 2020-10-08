using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAnoymousLamba
{
    class Lambda
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                2,4,6,8,10,12,11,13,5,3
            };
            Console.WriteLine("elements of list are:");
            Console.WriteLine();

            foreach(var nums in numbers)
            {
                Console.WriteLine("{0}", nums);
            }
            Console.WriteLine();

            //1.using lambda exp to ADD the numbers 
            var add = numbers.Select(x => x + x);

            foreach(var value in add)
            {
                Console.WriteLine("Addition of the number:{0}\n", value);
            }

            //2.using lambda exp to Multiple the numbers 
            var mul = numbers.Select(x => x * x);

            foreach (var value in mul)
            {
                Console.WriteLine("Multiplication of the number:{0}\n", value);
            }

            //3.using lambda exp to find even  numbers 
            var even = numbers.Select(x => x%2==0);

            foreach (var value in even)
            {
                Console.WriteLine("Even numbers:{0}\n", value);
            }

            //4.using lambda exp to find odd  numbers 
            var odd = numbers.Select(x => x % 2 == 1);

            foreach (var value in odd)
            {
                Console.WriteLine("Odd numbers:{0}\n", value);
            }

            Console.ReadLine();



        }
    }
}
