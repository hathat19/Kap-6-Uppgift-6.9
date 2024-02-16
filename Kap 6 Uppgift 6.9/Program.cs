using System;
using System.Collections.Generic;
namespace Uppgift6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuChoice = "";

            while (menuChoice != "3")
            {
                //Meny
                Console.WriteLine("Välj ett alternativ:");
                Console.WriteLine("1. Är n ett primtal?\r\n2. Antalet primtal mindre än n.\r\n3. Avsluta programmet.");
                menuChoice = Console.ReadLine();

                //Menyalternativ
                switch (menuChoice)
                {
                    case "1":
                        MenuChoice1();
                        break;

                    case "2":
                        MenuChoice2();
                        break;

                    case "3":
                        Console.WriteLine("Du stängde av programmet.");
                        break;

                    default:
                        Console.WriteLine("Du skrev ett ogiltigt alternativ. Försök igen."); 
                        break;
                }
                Console.WriteLine();
            }
        }

        static void MenuChoice1()
        {
            Console.WriteLine("Skriv in ett heltal. Programmet ska bestämma om det är ett primtal eller inte.");
            int userInt = ReadInt();

            if (PrimtalEllerInte(userInt))
            {
                Console.WriteLine($"{userInt} är ett primtal.");
            }
            else
            {
                Console.WriteLine($"{userInt} är inte ett primtal.");
            }

        }

        static void MenuChoice2()
        {
            Console.WriteLine("Skriv in ett heltal. Programmet ska hitta alla primtal före det talet.");
            int userInt = ReadInt();
            HurMångaPrimtalInnanZ(userInt);
        }

        /// <summary>
        /// Undersöker om en int är ett primtal eller inte.
        /// </summary>
        /// <param name="x"></param>
        /// <returns>True/False</returns>
        static bool PrimtalEllerInte(int x)
        {
            x = Math.Abs(x);

            for (int i = 0; i < x; i++)
            {
                if (i == 0 || i == x - 1) continue;
                else if (x % (i + 1) == 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Beräknar hur många primtal det finns innan ett visst tal. 
        /// </summary>
        /// <param name="z"></param>
        static void HurMångaPrimtalInnanZ(int z)
        {
            int nrOfPrimesBeforeZ = 0;
            List<int> primesBeforeZ = new List<int>();

            for (int i = 2; i < z; i++)
            {
                if (PrimtalEllerInte(i))
                {
                    nrOfPrimesBeforeZ++;
                    primesBeforeZ.Add(i);
                }
            }

            Console.WriteLine($"Det finns {nrOfPrimesBeforeZ} primtal innan {z}.");
            if (nrOfPrimesBeforeZ != 0)
            {
                Console.WriteLine("De inkluderar:");
                foreach (int prime in primesBeforeZ)
                {
                    Console.WriteLine(prime);
                }
            }

        }

        static int ReadInt()
        {
            int integer;
            while (int.TryParse(Console.ReadLine(), out integer) == false)
            {
                Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
            }
            return integer;
        }
    }
}
/*Skapa ett menyprogram med följande alternativ.
1. Är n ett primtal?
2. Antalet primtal mindre än n
3. Avsluta programmet
I alternativ 1 så ska användaren få skriva in ett heltal, programmet ska berätta för
användaren om det är ett primtal eller inte. I alternativ 2 så ska användaren få skriva
in ett heltal och programmet ska berätta antalet primtal som är mindre än det
inskrivna talet. Programmet ska vara uppdelat i metoder och det ska dessutom
använda sig av de metoder du har skrivit i de föregående uppgifterna.*/