using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAnoymousLamba
{
    //defining delegates
    public delegate double MulnumsDelegate(int x, float y, double z);
    public delegate double AddnumsDelegate(int x, float y, double z);

    public delegate void SubnumsDelegate(int x, float y, double z);
    public delegate void Subnums1Delegate1(int x, float y, double z);

    public delegate bool checkevenDelegate(int a);
    public delegate bool checkoddDelegate(int a);

    class Delegate
    {
        //method 1 with returning values
        public static double Mulnums(int x, float y, double z)
        {
            return ( x * y * z);
        }


        //method 2 with returning values
        public static double Addnums(int x, float y, double z)
        {
            return (x + y + z);
        }

        //method 3 without returning values
        public static void Subnums(int x, float y, double z)
        {
            Console.WriteLine(x - y - z);
        }

        //method 4 without returning values
        public static void Subnums1(int x, float y, double z)
        {
            Console.WriteLine(x - y - z);
        }

        //method 5 to return bool value
        public static bool checkeven(int a)
        {
            if (a % 2 == 0)
                return true;
            return false;
        }

        //method 6 to return bool value
        public static bool checkodd(int a)
        {
            if (a % 2 == 1)
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            //instatiation and invoking of method 1
            MulnumsDelegate obj1 = new MulnumsDelegate(Mulnums);
            double result1 = obj1.Invoke(5, 3.5f, 3456.68763);
            Console.WriteLine(result1);

            //instatiation and invoking of method 2
            AddnumsDelegate obj2 = new AddnumsDelegate(Addnums);
            double result2 = obj2.Invoke(5, 3.5f, 3456.68763);
            Console.WriteLine(result2);

            //instatiation and invoking of method 3
            SubnumsDelegate obj3 = new SubnumsDelegate(Subnums);
            obj3.Invoke(5, 3.5f, 3456.68763);

            // //instatiation and invoking of method 4
            Subnums1Delegate1 obj4 = new Subnums1Delegate1(Subnums1);
            obj4.Invoke(5, 3.5f, 3456.68763);

            //instatiation and invoking of method 5
            checkevenDelegate obj5 = new checkevenDelegate(checkeven);
            bool check = obj5.Invoke(4);
            Console.WriteLine(check);

            //instatiation and invoking of method 6
            checkoddDelegate obj6 = new checkoddDelegate(checkodd);
            bool checks = obj6.Invoke(4);
            Console.WriteLine(checks);

            Console.ReadLine();




        }
    }
}
