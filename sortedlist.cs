using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpSortedlist
{
    class sortedlist
    {
        static void Main(string[] args)
        {
            SortedList<int, string> numbers = new SortedList<int, string>();
            numbers.Add(10, "ten");
            numbers.Add(1, "one");
            numbers.Add(8, "eight");
            numbers.Add(5, "five");
            numbers.Add(4, "null");

            foreach(var check in numbers)
            {
                Console.WriteLine("element after sort" +"key:{0},value:{1} " ,check.Key  , check.Value);
            }
            Console.ReadLine();
        }
    }
}
