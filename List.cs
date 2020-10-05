using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpList
{
    class List
    {
        static void Main(string[] args)
        {
            var user = new List<string>();
            user.Add("Dhoni is");
            user.Add("captain cool");
            user.Add("virat is");
            user.Add("Aggressive");
            user.Add("In Cricket");
            Console.WriteLine("List created");
            foreach (var list in user)

            {
               
                Console.WriteLine("the elements in list is" + " "  + list);

            }
            Console.WriteLine("checking for remove method" + user.Remove("In Cricket"));

            var players = new List<string>() { "Dhoni", "Bhuvi", "Kapil", "Sourav", "Kohli", "Rohit" };
            //foreach(var x in players)
            //{
            //    Console.WriteLine("Another way of creating a list" + x);
            //}

            Console.WriteLine("The 1st index of the list is:" + players[0]);
            Console.WriteLine("The 2nd index of the list is:" + players[1]);
            Console.WriteLine("The 3rd index of the list is:" + players[2]);
            Console.WriteLine("The 4th index of the list is:" + players[3]);
            Console.WriteLine("The 5th index of the list is:" + players[4]);
            Console.WriteLine("The 6th index of the list is:" + players[5]);

            //insert(position,value)
            players.Insert(6, "yuvi");
            Console.WriteLine("the 6th element inserted with insert method is" + " "+ players[6]);

            //contains() returns boolean value is true /false

            Console.WriteLine(players.Contains("Rohit"));
            Console.ReadLine();
            
        }

    }
}
