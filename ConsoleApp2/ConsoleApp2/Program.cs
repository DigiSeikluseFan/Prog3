using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            int min = 0;
            int max = 0;

            while (true)
            {
                Console.Write("Palun sisesta number: ");
                string inputString = Console.ReadLine();
                int input;

                if (string.IsNullOrEmpty(inputString))
                {
                    break;
                }
                else
                {
                    input = Convert.ToInt32(inputString);
                }

                summa += input;
                Console.WriteLine("Summa: {0}", summa);

                if (input < min || min == 0)
                {
                    min = input;
                    Console.WriteLine("Min: {0}", min);
                }
                if (input > max || max == 0)
                {
                    max = input;
                    Console.WriteLine("Max: {0}", max);
                }
            }
            Console.WriteLine("Summa: {0}   Min: {0}   Max: {0}", summa, min, max);//pole kindel selles kohas 
        }
    }
}
