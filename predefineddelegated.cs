using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAnoymousLamba
{
    public delegate double MulnumsDelegate2(int x, float y, double z);
    public delegate double AddnumsDelegate2(int x, float y, double z);

    public delegate void SubnumsDelegate2(int x, float y, double z);
    public delegate void Subnums1Delegate3(int x, float y, double z);

    public delegate bool checkevenDelegate2(int a);
    public delegate bool checkoddDelegate2(int a);

    class predefineddelegated
    {
        static void Main(string[] args)
        {
            Func<int, float, double, double> obb1 = (x, y, z) => (x * y * z);
            double result1 = obb1.Invoke(1, 2.1f, 2435.123);
            Console.WriteLine(result1);

            Func<int, float, double, double> obb2 = (x, y, z) => (x + y + z);
            double result2 = obb2.Invoke(1, 2.1f, 2435.123);
            Console.WriteLine(result2);

            Action<int, float, double> obb3 = (x, y, z) => Console.WriteLine(x - y - z);
            obb3.Invoke(1, 2.1f, 2435.123);

            Action<int, float, double> obb4 = (x, y, z) => Console.WriteLine(x - y - z);
            obb4.Invoke(1, 2.1f, 2435.123);

            Predicate<int> obb5 = (num) =>
               {
                   if (num%2 == 0)
                       return true;
                   return false;

               };

            Predicate<int> obb6 = (num) =>
            {
                if (num % 2 == 1)
                    return true;
                return false;

            };

            bool print = obb5.Invoke(3);
            Console.WriteLine(print);

            bool prints = obb6.Invoke(3);
            Console.WriteLine(prints);

            Console.ReadLine();


        }
    }
}
