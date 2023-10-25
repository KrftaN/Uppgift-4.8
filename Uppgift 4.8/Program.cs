using System;

class Program
{
    static void Main()
    {
        Console.Write("Skriv in en sträng: ");
        string strängen = Console.ReadLine();

        if (strängen.Length < 2)
        {
            Console.WriteLine("Strängen måste vara minst 2 tecken lång.");
        }
        else
        {
            Console.Write("Skriv in två tecken: ");
            string teckenStrang = Console.ReadLine();

            if (teckenStrang.Length != 2)
            {
                Console.WriteLine("Du måste skriva exakt två tecken.");
            }
            else
            {
                bool finnsBadaTecknen = strängen.Contains(teckenStrang[0].ToString()) && strängen.Contains(teckenStrang[1].ToString());

                if (finnsBadaTecknen)
                {
                    Console.WriteLine("Båda tecknen finns i huvudsträngen.");
                }
                else
                {
                    Console.WriteLine("Inte båda tecknen finns i huvudsträngen.");
                }
            }
        }
    }
}
