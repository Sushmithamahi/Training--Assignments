using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CsharpRegex
{
    class RegExp
    {
        static void Main(string[] args)
        {
            //using MATCH and REGEX
                         
            //apply regex and find for match value
            //step1:create a regex--object needs to be created
            
            Regex example = new Regex(@"on\B");//find the dgits present/match in the string

            Regex e = new Regex(@"\D+");//return a match where string doesnt contain digit

            //step2:call the match on the regex instance

            Match Match = example.Match("Today is 1 st monday and 6 th  @ oct_20");//string

            Match M = e.Match("Today is 1 st monday and 6 th  @ oct_20");


            //step3:test for validation

            if (Match.Success)
            {
                Console.WriteLine("The match value :" + Match.Value);//match is inbuilt to find matching
                Console.WriteLine("pattern matched");
            }
            if (M.Success)
            {
                Console.WriteLine("The match value :" + M.Value);//match is inbuilt to find matching
                Console.WriteLine("pattern matched");
            }

            string test = "aabb";

            //match the start of a string
            if (Regex.IsMatch(test,"(aa|bb)"))
            {
                Console.WriteLine("pattern match,where string is startig with");
            }

            string value = " 10 and 20 and 30 and 40" ;
           

                //step1:get firstmatch
                Match mat = Regex.Match(value, @"\d+");//find digits present in the string


                if (mat.Success)
                {
                    Console.WriteLine("pattern matched and digits are :" + mat.Value);
                }


                //step2:get second match

                mat = mat.NextMatch();
                if (mat.Success)
                {
                    Console.WriteLine("the second executed and digits are:" + mat.Value);
                }
            

            // USING REGEX.MATCH

            //input string
            string input = "/content/alternate-1.aspx";

            //call Regex.Match
            Match match = Regex.Match(input, @"content([A-Za-z0-9\-]+)\.aspx$", RegexOptions.IgnoreCase);

            //check match for success
            if(match.Success)
            {
               // string key = match.Groups[1].Value;
                Console.WriteLine("VALUE" + match.Value);
                //Console.WriteLine(key);
            }

            //USING ISMATCH,START AND END 

            string t = "DXC Training";

            //match the start of the string
            if(Regex.IsMatch(t,"^DXC"))
            {
                Console.WriteLine("start matches");
            }

            //match the end of the string
            if(Regex.IsMatch(t,"Training$"))
            {
                Console.WriteLine("end matches");
            }

            //USING REPLACE ,REPLACE WITH PATTERN

            //Replace 2 or more digit pattern with a string
            Regex regex = new Regex(@"\d+");
            string result = regex.Replace("Fourty 40 44", "Fourtyfour");
            Console.WriteLine("Result:{0}", result);

            Console.ReadLine();

        }

     
            

            
            

            

    }
}
