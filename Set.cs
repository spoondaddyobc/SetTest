using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SetTest
{
    public class Set
    {
        #region Fields
        private List<int> firstSet = new List<int>();
        private List<int> secondSet = new List<int>();
        #endregion


        #region Properties

        //Accessors for the sets.
        public List<int> FirstSet
        {
            get
            {
                return firstSet;
            }

            set
            { 
                firstSet = value; 
            }
        
        }



        public List<int> SecondSet
        {
            get
            {
                return secondSet;
            }

            set
            {
                secondSet = value;
            }

        }
        #endregion


        #region Methods


        //Takes the parameters given and creates the first set list of the unique numbers.
        public void AddToFirstSet(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (FirstSet.Contains(list[i]) == false)
                {
                    FirstSet.Add(list[i]);
                }
            }
            FirstSet.Sort();            
        }

        //Takes the parameters given and creates the second set list of the unique numbers.
        public void AddToSecondSet(params int[] list)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (SecondSet.Contains(list[i]) == false)
                {
                    SecondSet.Add(list[i]);
                }
            }
            SecondSet.Sort();
        }


        //Displays values of the set specified to the user cleanly.
        public void DisplayValues(List<int> list)
        {
            Console.Write("( ");
            list.ForEach(i => Console.Write("{0}"+" ", i));
            Console.Write(")");
        }



        //Compares the two sets and creates a result set of all unique integers
        public void Union()
        {
            List<int> result = new List<int>(firstSet);

            for (int i = 0; i < secondSet.Count; i++)
            {
                if (result.Contains(secondSet[i]) == false)
                {
                    result.Add(secondSet[i]);
                }
            }
            result.Sort();

            Console.Write("Result of Union: ( ");
            result.ForEach(i => Console.Write("{0}" + " ", i));
            Console.Write(")");

        }

        //Compares the two sets and displays a resulting set of integers that exist in both that were compared.
        public void Intersect()
        {
            List<int> result = new List<int>();
            {
                for (int i = 0; i < firstSet.Count; i++)
                {
                    if (secondSet.Contains(firstSet[i]))
                    {
                        result.Add(firstSet[i]);
                    }
                }

                result.Sort();

                Console.Write("Intersect Result: ( ");
                result.ForEach(i => Console.Write("{0}" + " ", i));
                Console.Write(")");
                
            }
        }

        //Compares the set input, takes the range input, creates and displays a result set of only the integers that do NOT exist in the set that was passed in.
        public void Complement(List<int> list)
        {
            string input;
            int valueRange;

            List<int> result = new List<int>();

            Console.Write("Please specify the range of integer values for the complement: ");
            input = Console.ReadLine();
            if (Int32.TryParse(input, out valueRange))
            {
                for (int i = 0; i <= valueRange; i++)
                {
                    if (list.Contains(i) == false)
                    {
                        result.Add(i);
                    }

                }
                Console.Write("Complement Result: ( ");
                result.ForEach(i => Console.Write("{0}" + " ", i));
                Console.Write(")");   
            }
            else
            {
                Console.WriteLine("Invalid range entered. Please change it.");
            }
        }
        #endregion


        
        #region Constructor
        public Set()
        {
        }
        #endregion




    }
}
