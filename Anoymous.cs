using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAnoymousLamba
{
    //defining delegates
    public delegate double MulnumsDelegate1(int x, float y, double z);
    public delegate double AddnumsDelegate1(int x, float y, double z);

    public delegate void SubnumsDelegate1(int x, float y, double z);
    public delegate void Subnums1Delegate2(int x, float y, double z);

    public delegate bool checkevenDelegate1(int a);
    public delegate bool checkoddDelegate1(int a);

    class Anoymous
    {
        static void Main(string[] args)
        {
            //instiatate the delegate
            //1 anoymous method
            MulnumsDelegate1 ob1 = delegate (int x, float y, double z)
            {
                return (x * y * z);
            };

            //instiatate the delegate
            //2 anoymous method
            AddnumsDelegate1 ob2 = delegate (int x, float y, double z)
             {
                 return (x + y + z);
             };

            //instiatate the delegate
            //3 anoymous method
            SubnumsDelegate1 ob3 = delegate (int x, float y, double z)
            {
                Console.WriteLine (x - y - z);
            };

            //instiatate the delegate
            //4 anoymous method
            Subnums1Delegate2 ob4 = delegate (int x, float y, double z)
              {
                  Console.WriteLine(x - y - z);
              };

            //instiatate the delegate
            //5 anoymous method
            checkevenDelegate1 ob5 = delegate (int num)
            {
                if (num % 2 == 0)
                    return true;
                return false;
            };

            //instiatate the delegate
            //6 anoymous method
            checkoddDelegate1 ob6 = delegate (int num)
              {
                  if (num % 2 == 1)
                      return true;
                  return false;
              };

            // invoking for 1 anoymous method
            double d = ob1.Invoke(3, 2.5f, 234.2335);
            Console.WriteLine(d);

            // invoking for 2 anoymous method
            double d1 = ob2.Invoke(3, 2.5f, 234.2335);
            Console.WriteLine(d1);

            // invoking for 3  anoymous method
             ob3.Invoke(3, 2.5f, 234.2335);

            // invoking for 4  anoymous method
            ob4.Invoke(3, 2.5f, 234.2335);

            // invoking for 5 anoymous method
            bool check = ob5.Invoke(4);
            Console.WriteLine(check);

            // invoking for 6 anoymous method
            bool checks = ob6.Invoke(4);
            Console.WriteLine(checks);

            Console.ReadLine();

        }
    }
}
