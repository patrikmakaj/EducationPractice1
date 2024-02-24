// 4.	Napisati program koji generira random broj između 1 i 100 (uključujući oba).
// Potrebno je upisivati broj dok ne uspijemo pogoditi. Ako je broj manj od generiranog ispisati poruku “Prenisko, pokušaj ponovo”,
// slično za slučaj kad je broj veći. Nakon svakog unosa, potrebno je ponovo ponuditi unos broja sve dok ne uspijemo pogoditi. 
// Kada uspijemo pogoditi, potrebno je ispisati “Bravo, broj je pogođen”.
public class Zadatak4
{
    public static void Run()
    {
        var random = new Random();
        int number = random.Next(0, 100);
        int guess;
        Console.WriteLine("Pogodi broj od 1 do 100!");
        do
        {
            if (!int.TryParse(Console.ReadLine(), out guess))
            {
                Console.WriteLine("Krivi unos, molimo unesi broj.");
                return;
            }

            if (guess < number)
            {
                Console.WriteLine("Prenisko, pokušaj ponovno!");
            }
            else if (guess > number)
            {
                Console.WriteLine("Previsoko, pokušaj ponovno!");
            }
            else
            {
                Console.WriteLine("Bravo, broj je pogođen!");
            }
        }
        while (guess != number);
    }
}
