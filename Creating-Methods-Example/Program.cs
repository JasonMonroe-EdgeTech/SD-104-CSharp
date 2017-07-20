using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_Methods_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            SayHi();//internal method call
            Sing();//internal method call
            Console.ReadLine();//method call from Console class
        }

        static void SayHi()
        {
            Console.WriteLine("Hello, Dave...I am HAL 9000");
        }

        static void Sing()
        {
            Console.WriteLine("Daisy, Daisy, give me your answer true...");
        }

    }
}
