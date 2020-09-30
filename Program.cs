using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssigns
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.to remove duplicate items
            int[] nums = { 1, 2, 4, 2, 3, 5, 3, 6, 2, 7, 1 };
            int[] dist = nums.Distinct().ToArray();
            Array.ForEach(dist, v => Console.WriteLine(v));

            //2. to show largest number
            Console.WriteLine("Largest in given " + "array is " + largest());

            //3.to show whether given number is armstrong or not
            int n, r, sum = 0, temp;
            Console.Write("Enter the Number= ");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("Armstrong Number.");
            else
                Console.WriteLine("Not Armstrong Number.");

            //4.to print N prime numbers between 2 and 17
            int N = 17;

            printfirst_N_primes(N);

            Console.ReadLine();


        }

        //largest number
        static int[] arr = { 23, 53, 45, 60 };

        // Method to find maximum in arr[] 
        static int largest()
        {
            int i;

            // Initialize maximum element 
            int max = arr[0];
            for (i = 1; i < arr.Length; i++)
                if (arr[i] > max)
                    max = arr[i];

            return max;
        }

        //prime numbers between the series 2,3........,17
        static void printfirst_N_primes(int N)
        {
            int i, j, flag;
            Console.Write("Prime numbers between 2 and " + N + " are:\n");

            for (i = 2; i <= N; i++)
            {
                // flag variable to tell  
                // if i is prime or not 
                flag = 1;

                for (j = 2; j <= i / 3; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                // flag = 1 means i is prime  
                // and flag = 0 means i is not prime  
                if (flag == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }

       









    }
}

        
  
    
        
        
      

