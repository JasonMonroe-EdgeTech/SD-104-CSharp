using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ref_vs_val
{
    class testing
    {
        static void Main(string[] args)//This Main demonstrates reference vs value based parameters
        {
            //declare and initialize various types
            int intAlpha = 0;
            int[] intArrayBeta = { 0, 1, 2 };
            string strGamma = "Hello";
            List<Person> listOfPersons = new List<Person>();
            listOfPersons.Add(new Person("John"));
            listOfPersons.Add(new Person("Bon"));
            listOfPersons.Add(new Person("Jovi"));


            //display before method call
            Console.WriteLine("Alpha in main (before PassByVal): {0}", intAlpha);
            Console.Write("Beta in main (before PassByVal): { ");
            foreach (int element in intArrayBeta)
            {
                Console.Write(element + " ");
            }
            Console.Write(" }\n");

            Console.WriteLine("Gamma in main (before PassByVal): {0}", strGamma);
            Console.Write("Delta in main (before PassByVal): ");
            foreach (Person peep in listOfPersons)
            {
                Console.Write(peep.Name + " ");
            }
            Console.WriteLine("\n\n");

            //pass to array
            PassByVal(intAlpha, intArrayBeta, strGamma, listOfPersons);

            //display values after method call
            Console.WriteLine("Alpha in main (after PassByVal): {0}", intAlpha);
            Console.Write("Beta in main (after PassByVal): { ");

            foreach (int element in intArrayBeta)
            {
                Console.Write(element + " ");
            }
            Console.Write(" }\n");

            Console.WriteLine("Gamma in main (after PassByVal): {0}", strGamma);
            Console.Write("Delta in main (after PassByVal): ");
            foreach (Person peep in listOfPersons)
            {
                Console.Write(peep.Name + " ");
            }
            Console.WriteLine("\n\n");

            PassByRef(ref intAlpha, ref intArrayBeta, ref strGamma, ref listOfPersons);//method call
            Console.WriteLine("strGamma and listOfPersons after method (within Main): {0}", strGamma);
            foreach (Person peep in listOfPersons)
            {
                Console.Write(peep.Name + " ");
            }
            Console.WriteLine("\n\n");

            Console.WriteLine();
            Console.ReadLine();

        }//end Main


        //PassByVal
        private static void PassByVal(int alpha, int[] beta, string gamma, List<Person> delta)
        {
    

            //increase alpha and beta
            alpha++;
            for(int n = 0; n<beta.Length; n++)
            {
                beta[n]++;
            }

            //display values
            Console.WriteLine("Alpha in method PassByVal: {0}", alpha);
            Console.Write("Beta in method PassByVal: { ");

            foreach (int element in beta)
            {
                Console.Write(element+" ");
            }
            Console.Write(" }\n");

            //increase gamma and delta
            gamma = "Goodbye";
            for (int n = 0; n < delta.Count; n++)
            {
                delta[n].Name = "Newbie_" + n;
            }

            //display values
            Console.WriteLine("gamma in method PassByVal: {0}", gamma);
            Console.Write("delta in method PassByVal: ");

            foreach (Person peep in delta)
            {
                Console.Write(peep.Name + " ");
            }
            Console.WriteLine("\n\n");

            delta = new List<Person>();
            delta.Add(new Person("Michaelangelo"));
        }

        //PassByRef method
        private static void PassByRef(ref int alpha, ref int[] beta, ref string gamma, ref List<Person> delta)
        {
            //increase alpha and beta
            alpha+=3;
            for (int n = 0; n < beta.Length; n++)
            {
                beta[n]+=2;
            }

            //display values
            Console.WriteLine("Alpha in method PassByRef: {0}", alpha);
            Console.Write("Beta in method PassByRef: { ");

            foreach (int element in beta)
            {
                Console.Write(element + " ");
            }
            Console.Write(" }\n");

            //increase gamma and delta
            gamma = "Temmet Nosce";
            for (int n = 0; n < delta.Count; n++)
            {
                delta[n].Name = "Newbie_"+(n+4);
            }

            //display values
            Console.WriteLine("gamma in method PassByRef: {0}", gamma);
            Console.Write("delta in method PassByRef: ");

            foreach (Person peep in delta)
            {
                Console.Write(peep.Name + " ");
            }
            Console.WriteLine("");

            //set equal to new
            alpha = new int();
            alpha = 5;

            //beta = new int[]();
            //beta = { 7,7,7};

            //gamma = new String("The Matrix Has You...");
            //

            delta = new List<Person>();
            delta.Add(new Person("Donatello"));


        }

    }//end class

    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }

    }

}//end namespace
