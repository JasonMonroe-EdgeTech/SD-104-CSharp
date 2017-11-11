using System;
using System.Collections.Generic;
using System.IO;
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
            //Instantiate a FileStream that will open a file named "names.txt", 
            FileStream stream1 = new FileStream("names.txt", FileMode.Append, FileAccess.Write);
            StreamWriter textFile1 = new StreamWriter(stream1);

            Console.WriteLine("Enter a name or type -99 to quit:");
            string userInput = Console.ReadLine();

            //input loop
            while(userInput != "-99")
            {
                textFile1.WriteLine(userInput);
                Console.WriteLine("Enter a name or type -99 to quit:");
                userInput = Console.ReadLine();
            }

            textFile1.Close();
           


        }//end addNames()

        static void viewNames()
        {
            //instantiate a FileStream Object to open "names.txt" with FileMode.Open and FileAccess.Read

            //instantiate a StreamReader Object and pass to it the FileStream Object you created

            //read file in loop while the reader is not at the EndOfStream and display the lines of text

            //Close the file


        }//end viewNames()
    }


}
