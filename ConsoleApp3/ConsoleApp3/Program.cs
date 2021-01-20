using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sisesta number arvamiseks: ");
            int vastus = Convert.ToInt32(Console.ReadLine());
            int proovid = 0;
            bool arvamised;

            while (true)
            {
                Console.Write("Palun sisesta number arvamiseks: ");
                string inputString = Console.ReadLine();
                int input;

                if (string.IsNullOrEmpty(inputString))
                {
                    arvamised = false;
                    break;
                }
                else
                {
                    input = Convert.ToInt32(inputString);
                }


                if (input == vastus)
                {
                    proovid++;
                    arvamised = true;
                    break;
                }
                else if (input > vastus)
                {
                    Console.WriteLine("Arv on liiga suur.");
                    proovid++;
                }
                else if (input < vastus)
                {
                    Console.WriteLine("Arv on liiga väike.");
                    proovid++;
                }
            }

            if (arvamised == true)
            {
                Console.WriteLine("Õige vastus on {0}, arvasid ara {1} korraga.", vastus, proovid);
            }
            else
            {
                Console.WriteLine("Õige vastus on {0}, arvasid {1} korda, aga ei leidnud õiget vastust.", vastus, proovid);
            }
        }
    }
}
