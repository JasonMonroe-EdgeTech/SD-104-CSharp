using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declarations
            string strChoice = "";

            //menu loop
            while (strChoice != "3")
            {
                //main menu
                Console.WriteLine("-------Main Menu--------");
                Console.WriteLine("1.\tAdd Names to a File");
                Console.WriteLine("2.\tView Names in a File");
                Console.WriteLine("3.\tExit");
                strChoice = Console.ReadLine();


                //process choice
                switch (strChoice)
                {
                    case "1":
                        addNames();
                        break;
                    case "2":
                        viewNames();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine(strChoice+" is not a valid choice.");
                        break;
                }
            }

        }//end Main()

        static void addNames()
        {
            

        }//end addNames()

        static void viewNames()
        {
            DataAccessor dataAccessor = new DataAccessor();
            Console.ReadLine();

        }//end viewNames()
    }
}
