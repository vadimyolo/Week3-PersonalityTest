using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinnet sa täna said?");

            string number = Console.ReadLine();

            if (number == "5") 
            {
                Console.WriteLine("Väga suurepärane!");
            }
            else if (number == "4")
            {
                Console.WriteLine("Väga hea tulemus.");
            }
            else if (number == "3")
            {
                Console.WriteLine("Hea tulemus, aga saaksid paremini teha.");
            }
            else if (number == "2")
            {
                Console.WriteLine("Rahuldav tulemus.");
            }
            else if (number == "1")
            {
                Console.WriteLine("Puudulik hinne.");
            }
            else
            {
                Console.WriteLine("Väga, väga puudulik tulemus.");
            }
            Console.ReadLine();
        }
    }
}
