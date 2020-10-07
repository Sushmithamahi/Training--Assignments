using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpGeneric
{
    class example<T> //Type parameter <T>
    {
        T data;// Type parameter declared

        //A method for class example
        public example(T check)//constructor
        {
            this.data = check;
        }

        public void write()
        {
            Console.WriteLine("The passed to the initializer is:" + this.data);
        }

    }




    class Generic
    {
        static void Main(string[] args)
        {
            // to use the generic type example with an integer/string type parameter
            //Instaiating the class example
            example<int> result = new example<int>(100);
            example<string> result1 = new example<string>("sachin");
            

            //invoking the method write() with object created result and result1
            result.write();
            result1.write();
            Console.ReadLine();
        }
        
    }
}
