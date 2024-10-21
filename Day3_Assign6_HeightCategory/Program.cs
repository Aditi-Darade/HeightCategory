using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_Assign6_HeightCategory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Enter your height in inches: ");
            string stringInchesHeight = System.Console.ReadLine();
            double InchesHeight = double.Parse(stringInchesHeight);
            double CentiHeight = InchesHeight * 2.54;

            if (CentiHeight <= 150)
            {
                System.Console.WriteLine("Dwarf");
            }
            else if (150 < CentiHeight && CentiHeight <= 165)
            {
                System.Console.WriteLine("Average height");
            }
            else if (165 < CentiHeight && CentiHeight <= 195)
            {
                System.Console.WriteLine("Tall");
            }
            else
            {
                System.Console.WriteLine("Abnormal height");
            }
            System.Console.ReadKey();
        }
    }
}
