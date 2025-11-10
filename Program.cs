namespace Vereinsbeitrag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Berechnen Sie Ihren Vereinsbeitrag.");
            Console.WriteLine("Wie alt sind Sie?");
            int alter = Convert.ToInt32(Console.ReadLine());



            if (alter <= 6)
            {
                Console.WriteLine("Beitrag: frei");
            }
            else if (alter >= 7 && alter <= 17)
            {
                Console.WriteLine("Beitrag: 30 Euro");
            }
            else if (alter >= 18 && alter <= 65)
            {
                string erwerbstätig = "";

                while (erwerbstätig != "j" && erwerbstätig != "n")
                {
                    Console.WriteLine("Sind Sie erwerbstätig? (j/n)");
                    erwerbstätig = Console.ReadLine().ToLower();

                    if (erwerbstätig == "j")
                    {
                        Console.WriteLine("Beitrag: 80 Euro");
                    }
                    else if (erwerbstätig == "n")
                    {
                        Console.WriteLine("Beitrag: 40 Euro");
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe, versuchen Sie es erneut.");
                    }
                }
            }

            else
            {
                Console.WriteLine("Beitrag: 50 Euro");
            }
        }
    }
}

