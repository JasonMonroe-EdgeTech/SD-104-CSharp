using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Structure_Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            ForLoop();
            LoopWithBreak();
            LoopWithContinue();
            SentinalLoop();
            NestedIF();
        }

        static void ForLoop()
        {

            int nCount = 4;

            //loops until n < nCount is false.
            //increments n by 1 each iteration.
            for (int n = 0; n < nCount; n++)
            {
                Console.WriteLine("The count is " + n);
            }

            Console.ReadLine();

        }

        static void LoopWithBreak()
        {
            int nCount = 4;

            //break statement exists loop completely when n == 2.  
            //Happens before 2 is printed.
            for (int n = 0; n < nCount; n++)
            {
                if (n == 2)
                {
                    break;
                }
                Console.WriteLine("The count is " + n);
                
            }

            Console.ReadLine();
        }

        static void LoopWithContinue()
        {
            int nCount = 4;

            //Continue statement skips rest of loop and
            //starts the loops back at the top when n == 2.
            //This skips the printing of "The count is 2".
            for (int n = 0; n < nCount; n++)
            {
                if (n == 2)
                {
                    continue;
                }
                Console.WriteLine("The count is " + n);
                
            }

            Console.ReadLine();
        }

        static void SentinalLoop()
        {
            int nTestScore = 0, nTotalScores= -1;
            double dblRunningTotal = 0;

           //loops until sentinel value -99 is typed.
            while(nTestScore !=-99)
            {
                nTotalScores++;
                dblRunningTotal += nTestScore;

                //initial prompt
                Console.Write("Enter a test score or -99 to exit: ");
                nTestScore = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("The score average is: " + dblRunningTotal / nTotalScores);
            Console.ReadLine();
        }

        static void NestedIf()
        {
            //variable declarations
            int nAge;
            string strIsRegistered;

            //prompt for age
            Console.WriteLine("What is your age: ");
            nAge = Convert.ToInt32(Console.ReadLine());

            //age decision layer
            if(nAge >= 18)
            {
                //ask user if they have registered
                Console.WriteLine("Have you registered? Type Y or N: ");
                strIsRegistered = Console.ReadLine();

                //registered decision nested layer
                if(strIsRegistered == "Y")
                {
                    Console.WriteLine("You can vote.  Please proceed to the ballot counter.");
                }
                else
                {
                    Console.WriteLine("You must register in order to vote.");
                }
            }
            else
            {
                Console.WriteLine("You are too young to vote.");
            }
        }

        static void VariableScope()
        {
            string strUserChoice;
            Console.WriteLine("Solve a math problem for bonus points? Type Yes or No: ");
            strUserChoice = Console.ReadLine();

            if(strUserChoice == "Y")
            {
                Console.WriteLine("What is 5 + 5?");
                int answer = 5 + 5;
                int userAnswer = Convert.ToInt32(Console.ReadLine());
            }

            if(userAnswer == answer)
            {

            }
            
        }
    }
}
