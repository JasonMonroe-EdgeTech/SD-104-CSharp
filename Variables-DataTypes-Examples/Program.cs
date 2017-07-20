using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_DataTypes_Examples
{
    class Program
    {
        static void Main(string[] args)
        {

            ConstantsDecimal();
            ConstantsDecimalFixed();


        }

        static void ConstantsDecimal()
        {
            decimal dcmFees = 10, dcmTotal;
            const decimal TAX_RATE = 0.08M;

            //Prompt user for total
            Console.Write("Enter purchase total: ");
            dcmTotal = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Your total including fees and taxes is: {0:C}", dcmTotal + (TAX_RATE * dcmTotal) + dcmFees);
            Console.ReadLine();
        }

        static void ConstantsDecimalFixed()
        {
            bool boolValidData;
            decimal dcmFees = 10, dcmTotal;
            const decimal TAX_RATE = 0.08M;

            //Input Validation Loop
            do
            {
                //Set boolean flag to true
                boolValidData = true;

                Console.Write("Enter purchase total: ");

                //if input cannot be parsed or else it is less than 0, set flag to false
                if (Decimal.TryParse(Console.ReadLine(), out dcmTotal)==false)
                {
                    boolValidData = false;
                    Console.WriteLine("Not a recognizable value.");
                }
                else if(dcmTotal <0)
                {
                    boolValidData = false;
                    Console.WriteLine("Value must be greater than zero.");
                }
                
            } while (boolValidData == false);

            //display results
            Console.WriteLine("Your total including fees and taxes is: {0:C}", dcmTotal + (TAX_RATE * dcmTotal) + dcmFees);
            Console.ReadLine();

        }

    }
}
