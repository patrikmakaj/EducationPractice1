// 2.	Ispisati fibonacijev niz ovisno o broju koji upišemo (ako upišemo broj 1000, do broja 1000 ispisati niz).
// Također dodatno je potrebno zbrojati svaki drugi u (znači zbrojati 1+3+5+7+…. u nizu, te također 2+4+6+8+….)
// ispisati zbroj jednog  i drugog. Ako slučajno netko ne zna što je fibonacijev niz, istražite.
// Pravila vezana za unos, također primjeniti ovdje (trebala bi biti ista)

public class Zadatak2
{
    public static void Run()
    {
        Console.Write("Unesite broj do kojeg želite ispisati Fibonaccijev niz: ");
        if (int.TryParse(Console.ReadLine(), out int target) && target > 0)
        {
            PrintFibonacciSequence(target);
        }
        else
        {
            Console.WriteLine("Pogresan unos. Molimo unesite pozitivan cijeli broj.");
        }
    }

    static void PrintFibonacciSequence(int target)
    {
        if (target <= 0)
        {
            Console.WriteLine("Pogresan unos. Molimo unesite pozitivan cijeli broj.");
            return;
        }

        int a = 0, b = 1;

        int sumOdd = 0;
        int sumEven = 0;

        Console.WriteLine("Fibonaccijev niz:");

        while (a <= target)
        {
            Console.Write($"{a} ");

            if (a % 2 == 0)
            {
                sumEven += a;
            }
            else
            {
                sumOdd += a;
            }

            int temp = a;
            a = b;
            b = temp + b;
        }

        Console.WriteLine($"\nZbroj neparnih elemenata: {sumOdd}");
        Console.WriteLine($"Zbroj parnih elemenata: {sumEven}");
        Console.WriteLine($"Zbroj svih elemenata: {sumOdd + sumEven}");
    }
}