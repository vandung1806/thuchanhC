// See https://aka.ms/new-console-template for more information
using System;

namespace practicebull
{
    //Matthew Busick
    //pos/408:.net1

    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("{insert/path/to/file}");

            const double tax = .07;

            const int months = 12;

            foreach (string line in lines)
            {
                string[] col = line.Split(new char[] { ',' });
                // process col[0], col[1], col[2]
                Console.WriteLine($"Engineer: {col[0]}");
                Console.WriteLine($"Lives at: {col[1]}");

                double salary = Convert.ToDouble(col[2]);

                double taxPaid = salary * tax;

                double annual = salary * months;

                double aTaxPaid = annual * tax;

                double net = salary - taxPaid;

                double aNet = annual - aTaxPaid;

                Console.WriteLine($"Monthly net pay: ${net}");
                Console.WriteLine($"Monthly Gross salary: ${salary}");
                Console.WriteLine($"Monthly taxes paid: ${taxPaid}");
                Console.WriteLine($"Annual net pay: ${aNet}");
                Console.WriteLine($"Annual Gross salary: ${annual}");
                Console.WriteLine($"Annual taxes paid: ${aTaxPaid} \n");
            }

        }
    }
}