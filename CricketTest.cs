using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    
        public abstract class Cricket
        {
        
       
            private int maxovers;
            public int Maxovers
            {
                get
                {
                    return maxovers;
                }
              set
              {
                maxovers = value;
              }
            }
            private int targetscore;
            public int Targetscore
            {
                get
                {
                    return targetscore;
                }
                set
                {
                    targetscore = value;
                }
            
        }
            private int currentover;
            public int Currentover
            {
                get 
                {
                    return currentover;
                }
                set
                {
                    currentover = value;
                }
            }
            private int currentscore;
            public int Currentscore
            {
                get
                {
                    return currentscore;
                }
                set
                {
                    currentscore = value;
                }
            }
          private int remainingruns;
          public int Remainingruns
          {
            get
            {
                return remainingruns;
            }
            set
            {
                remainingruns = value;
            }
          }
             private int remainingovers;
            public int Remainingovers
            {
              get
              {
                return remainingovers;
              }
              set
              {
                remainingovers = value;
              }
            }


            public abstract double CalcCurrentRunrate();
            public abstract double CalcReqdRunrate();

             
        



        }
    public class Onedaycricket : Cricket
    {



        public override double CalcCurrentRunrate()
        {
            throw new NotImplementedException();
        }

        public override double CalcReqdRunrate()
        {
            throw new NotImplementedException();
        }
        

        

    }
    class CricketTest
    {
        static void Main(string[] args)
        {
            Onedaycricket on = new Onedaycricket();


            on.Maxovers = 20;
            on.Targetscore = 200;
            on.Currentover = 5;
            on.Currentscore = 20;
            int Remainingruns = on.Targetscore - on.Currentscore;
            
            int Remainingovers = on.Maxovers - on.Currentover;

            double CalcCurrentRunrate = Remainingruns / Remainingovers;
            double CalcReqdRunrate = on.Currentscore / on.Currentover;
            
            Console.WriteLine("Enter maxovers:{0}",on. Maxovers);
            Console.WriteLine("Enter target runs:{0}", on.Targetscore);
            Console.WriteLine("Enter current over:{0}", on.Currentover);
            Console.WriteLine("Enter current score:{0}", on.Currentscore);

            Console.WriteLine("Remaining runs are:{0}", Remainingruns);
            Console.WriteLine("Remaining overs are:{0}", Remainingovers);
            Console.WriteLine("CalcReqdRunRate is:{0}", CalcReqdRunrate);
            Console.WriteLine("CalcCurrentRunrate is:{0}", CalcCurrentRunrate);
            Console.ReadLine();
        }
        
        

        
    }
    

}
