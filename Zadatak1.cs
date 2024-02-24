// 1. Ispisati sljedeći trokut koristeći petlje (proizvoljan unos, do maximalno 9).
// Potrebno napraviti i provjeru da broj nije veći od 9, te također zabraniti unos nečega 
// što nije broj (izbaciti poruku da nije ispravno uneseno)

public class Zadatak1
{
    public static void Run()
    {
        int i, j, k, z, n;

        do
        {
            Console.Write("Unesi broj 1-9: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out n) && n >= 1 && n <= 9)
            {
                break;
            }
            else
            {
                Console.WriteLine("Krivi unos. Pokusaj ponovno s brojem 1-9.");
            }
        } while (true);

        for (i = 0; i < n; i++)
        {
            for (z = n - i - 1; z > 0; z--)
            {
                Console.Write(" ");
            }
            for (j = 1; j < i + 1; j++)
            {
                Console.Write(j);
            }
            for (k = i + 1; k > 0; k--)
            {
                Console.Write(k);
            }
            Console.Write("\n");
        }
    }
}