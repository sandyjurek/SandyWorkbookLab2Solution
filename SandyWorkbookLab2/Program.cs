using System;
using System.Reflection.Metadata.Ecma335;

namespace SandyWorkbookLab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input3;

            do
            {
                Console.WriteLine("What is the width? (ie., 8 feet and 6 inches enter as 8.6)");
                decimal input1 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("What is the length?");
                decimal input2 = Convert.ToDecimal(Console.ReadLine());

                decimal sumArea = input1 * input2;
                decimal sumPeri = 2 * (input1 + input2);

                Console.WriteLine(sumArea + " Square Feet is the Area");
                Console.WriteLine(sumPeri + " Feet is the Perimeter");

                Console.WriteLine("Would you like to continue (yes/no)?");
                input3 = Console.ReadLine();
            }
            while (input3 == "yes");
            return;
        }
    }
}
