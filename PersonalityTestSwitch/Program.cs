using System;

namespace PersonalityTestSwitch
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

            switch(color)
            {
                case "punane":
                    Console.WriteLine("Oled Romantiline.");
                    break;
                case "sinine":
                    Console.WriteLine("oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("oled looduse sõber.");
                    break;
                default:
                    Console.WriteLine("oled imelik ükssarvik");
                    break;
            }
        }
    }
}
