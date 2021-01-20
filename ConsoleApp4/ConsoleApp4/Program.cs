using System;

namespace ConsoleApp4
{
    class Program
    {
        static string[,] manguvali = new string[,] { { " ", " ", " " }, { " ", " ", " " }, { " ", " ", " " } };
        static int ruudud = 9;
        static string mangija = "O";
        static string voitja;
        static bool mang = true;
        static int kasViik = 0;
        static void Main(string[] args)
        {
            while (mang == true)
            {
                Console.WriteLine(" {0} | {1} | {2} ", manguvali[0, 0], manguvali[0, 1], manguvali[0, 2]);
                Console.WriteLine(" {0} | {1} | {2} ", manguvali[1, 0], manguvali[1, 1], manguvali[1, 2]);
                Console.WriteLine(" {0} | {1} | {2} ", manguvali[2, 0], manguvali[2, 1], manguvali[2, 2]);

                if (Voit() == false)
                {
                    if (Viik() == false)
                    {
                        if (mangija == "O")
                        {
                            Console.WriteLine("Mängija 1 vali rida (1-3): ");
                            int vastusRida = Convert.ToInt32(Console.ReadLine()) - 1;

                            if (vastusRida <= 2 && vastusRida >= 0)
                            {
                                Console.WriteLine("Mängija 1 vali veerg (1-3): ");
                                int vastusVeerg = Convert.ToInt32(Console.ReadLine()) - 1;

                                if (vastusVeerg <= 2 && vastusVeerg >= 0)
                                {
                                    if (manguvali[vastusRida, vastusVeerg] != "O" && manguvali[vastusRida, vastusVeerg] != "X")
                                    {
                                        manguvali[vastusRida, vastusVeerg] = "O";
                                        mangija = "X";
                                    }
                                    else
                                    {
                                        Console.WriteLine("See ruut on juba veõtud, proovi uuesti.");
                                    }
                                }
                            }
                        }
                        else if (mangija == "X")
                        {
                            Console.WriteLine("Mängija 2 vali rida (1-3): ");
                            int vastusRida = Convert.ToInt32(Console.ReadLine()) - 1;

                            if (vastusRida <= 2 && vastusRida >= 0)
                            {
                                Console.WriteLine("Mängija 1 vali veerg (1-3): ");
                                int vastusVeerg = Convert.ToInt32(Console.ReadLine()) - 1;

                                if (vastusVeerg <= 2 && vastusVeerg >= 0)
                                {
                                    if (manguvali[vastusRida, vastusVeerg] != "O" && manguvali[vastusRida, vastusVeerg] != "X")
                                    {
                                        manguvali[vastusRida, vastusVeerg] = "X";
                                        mangija = "O";
                                    }
                                    else
                                    {
                                        Console.WriteLine("See ruut on juba võetud, proovi uuesti.");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        mang = false;
                        break;
                    }
                }
                else
                {
                    mang = false;
                    if (mangija == "X")
                    {
                        voitja = "1";
                    }
                    if (mangija == "O")
                    {
                        voitja = "2";
                    }
                    break;
                }
            }
            if (Voit() == true)
            {
                Console.WriteLine("Mang sai läbi võitajaks osutus mängija {0}.", voitja);
            }
            else if (Viik() == true)
            {
                Console.WriteLine("Viik!");
            }
        }
        static public bool Voit()
        {

            if ((manguvali[0, 0] == "X" && manguvali[0, 1] == "X" && manguvali[0, 2] == "X") || (manguvali[0, 0] == "O" && manguvali[0, 1] == "O" && manguvali[0, 2] == "O"))
            {
                return true;
            }
            if ((manguvali[1, 0] == "X" && manguvali[1, 1] == "X" && manguvali[1, 2] == "X") || (manguvali[1, 0] == "O" && manguvali[1, 1] == "O" && manguvali[1, 2] == "O"))
            {
                return true;
            }
            if ((manguvali[2, 0] == "X" && manguvali[2, 1] == "X" && manguvali[2, 2] == "X") || (manguvali[2, 0] == "O" && manguvali[2, 1] == "O" && manguvali[2, 2] == "O"))
            {
                return true;
            }
            if ((manguvali[0, 0] == "X" && manguvali[1, 0] == "X" && manguvali[2, 0] == "X") || (manguvali[0, 0] == "O" && manguvali[1, 0] == "O" && manguvali[2, 0] == "O"))
            {
                return true;
            }
            if ((manguvali[0, 1] == "X" && manguvali[1, 1] == "X" && manguvali[2, 1] == "X") || (manguvali[0, 1] == "O" && manguvali[1, 1] == "O" && manguvali[2, 1] == "O"))
            {
                return true;
            }
            if ((manguvali[0, 2] == "X" && manguvali[1, 2] == "X" && manguvali[2, 2] == "X") || (manguvali[0, 2] == "O" && manguvali[1, 2] == "O" && manguvali[2, 2] == "O"))
            {
                return true;
            }
            if ((manguvali[0, 0] == "X" && manguvali[1, 1] == "X" && manguvali[2, 2] == "X") || (manguvali[0, 0] == "O" && manguvali[1, 1] == "O" && manguvali[2, 2] == "O"))
            {
                return true;
            }
            if ((manguvali[0, 2] == "X" && manguvali[1, 1] == "X" && manguvali[2, 0] == "X") || (manguvali[0, 2] == "O" && manguvali[1, 1] == "O" && manguvali[2, 0] == "O"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool Viik()
        {
            for (int x = 0; x <= 2; x++)
            {
                for (int y = 0; y <= 2; y++)
                {
                    if (manguvali[x, y] == "X" || manguvali[x, y] == "O")
                    {
                        kasViik++;
                        if (kasViik >= ruudud)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            return true;
        }
    }
}