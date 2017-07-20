using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            FixedSentinelWithTryParse();

            

        }

        static void FixedSentinelWithTryParse()
        {
            int nTestScore = 0, nTotalScores = -1;
            double dblRunningTotal = 0;

            //loops until sentinel value -99 is typed.
            while (nTestScore != -99)
            {
                nTotalScores++;
                dblRunningTotal += nTestScore;

                //initial prompt
                Console.Write("Enter a test score or -99 to exit: ");
                if (Int32.TryParse(Console.ReadLine(), out nTestScore) == false)
                {
                    Console.WriteLine("That is not an integer.  Goodbye.");
                    break;
                }

            }

            Console.WriteLine("The score average is: " + dblRunningTotal / nTotalScores);
            Console.ReadLine();
        }

      


    }
}
