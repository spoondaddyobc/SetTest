using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetTest   
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciate and Set the values here.
            Set test = new Set();
            test.AddToFirstSet(4, 1, 6, 7, 8); 
            test.AddToSecondSet(13, 2, 5, 7, 6);
            
            //Display values of First Set
            test.DisplayValues(test.FirstSet);
            Console.ReadLine();

            //Display values of Second Set
            test.DisplayValues(test.SecondSet);
            Console.ReadLine();


            //Perform Union and display the results. 
            test.Union();
            Console.ReadLine();

            //Perform Intersect and display the results.
            test.Intersect();
            Console.ReadLine();

            //Perform Complement and display the results.
            test.Complement(test.FirstSet);
            Console.ReadLine();
           
        }
    }
}
