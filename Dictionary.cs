using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharpdictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> dictionary= new Dictionary<int, string>();
            //add()to enter /insert to dictionary
            dictionary.Add(1, "Bangalore");
            dictionary.Add(2, "Mumbai");
            dictionary.Add(3, "Pune");
            dictionary.Add(4, "Hyderabad");
            dictionary.Add(5, "chennai");
           

            foreach (KeyValuePair<int,string> check in dictionary) 
            {
                Console.WriteLine("elements of dict are: " +" "  + check.Key + check.Value);
                
            }
            Console.WriteLine("no of ele:"+ dictionary.Count());
            //set the item value like this also
            dictionary[6] = "Delhi";
            dictionary[7] = "Kolkata";
            dictionary[8] = "Ahmedabad";
            dictionary[9] = "Noida";

            foreach (KeyValuePair<int, string> check in dictionary)
            {
                Console.WriteLine("elements of dict are:" + check.Key + check.Value);

            }
            Console.WriteLine("no of ele:" + dictionary.Count());

            // remove() 2nd city
            Console.WriteLine("ele left in the dict after removing 2nd city" + dictionary.Remove(2));
            foreach (KeyValuePair<int, string> check in dictionary)
            {
                Console.WriteLine("elements of dict are:" + check.Key + check.Value);

            }
            Console.WriteLine("no of ele:" + dictionary.Count());


            //removing 3rd city
            Console.WriteLine("ele left in the dict after removing 3rd city" + dictionary.Remove(3));
            foreach (KeyValuePair<int, string> check in dictionary)
            {
                Console.WriteLine("elements of dict are:" + check.Key + check.Value);

            }
            Console.WriteLine("no of ele:" + dictionary.Count());

            //removing 4th city
            Console.WriteLine("ele left in the dict after removing 4th city" + dictionary.Remove(4));
            foreach (KeyValuePair<int, string> check in dictionary)
            {
                Console.WriteLine("elements of dict are:" + check.Key + check.Value);

            }
            Console.WriteLine("no of ele:" + dictionary.Count());

            //removing 5th city
            Console.WriteLine("ele left in the dict after removing 5th city" + dictionary.Remove(5));
            foreach (KeyValuePair<int, string> check in dictionary)
            {
                Console.WriteLine("elements of dict are:" + check.Key + check.Value);

            }
            Console.WriteLine("no of ele:" + dictionary.Count());


            //removing 6th city
            Console.WriteLine("ele left in the dict after removing 6th city" + dictionary.Remove(6));
            foreach (KeyValuePair<int, string> check in dictionary)
            {
                Console.WriteLine("elements of dict are:" + check.Key + check.Value);

            }
            Console.WriteLine("no of ele:" + dictionary.Count());

            Console.ReadLine();
        }
    }
}
