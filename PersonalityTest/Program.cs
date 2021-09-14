using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajat sisestada tema lemmikvärvi;
            //kui kasutaja sisestab "punane" siis kuvatatakse et ta on romantiline;
            //kui kasutaja sisestab "sinine" siis kuvatatakse et ta on töökas;
            //kui kasutaja sisestab "roheline" siis kuvatatakse seda et ta on looduse sõber;
            //kui aga ta sisestab midagi muud siis kuvatatakse teda sellega, et ta on ükssarvik;

            Console.WriteLine("Sisesta oma lemmikvärv.");

            string color = Console.ReadLine();

            if (color == "punane")
            {
                Console.WriteLine("Oled romantiline.");
            }
            else if (color == "sinine")
            {
                Console.WriteLine("Oled töökas mees!");
            }    
            else if (color == "roheline")
            {
                Console.WriteLine("Oled looduse friend.");
            }
            else 
            {
                Console.WriteLine("Oled veits ükssarvik.");
            }
            Console.ReadLine();
        }
    }
}
