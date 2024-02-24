// 3.	Napisati program koji prima dva broja te s tim brojevima ovisno o unesenom aritmetičkom znaku, odrađuje određenu operaciju.
// U slučaju da unesemo riječ “Sve”, potrebno je ispisati sve aritmetičke operacije.
// (+,-,*,/,% van toga nije potrebno – potenciranje/korijen su jos neki od, ako netko želi, može riješiti također ta dva,
// ali na način da se upravilu svaki broj potencira sa samim sobom, odnosno napravi se korijen svakog broja zasebno).
// Tip za ovaj zadatak je također da postoji neki slučaj koji nije moguć, bilo bi super da uspijete uhvatiti koji i ispišete posebnu poruku za taj slučaj.
public class Zadatak3
{
    public static void Run()
    {
        Console.Write("Unesite prvi broj: ");
        if (!double.TryParse(Console.ReadLine(), out double broj1))
        {
            Console.WriteLine("Pogrešan unos za prvi broj.");
            return;
        }

        Console.Write("Unesite drugi broj: ");
        if (!double.TryParse(Console.ReadLine(), out double broj2))
        {
            Console.WriteLine("Pogrešan unos za drugi broj.");
            return;
        }

        Console.Write("Unesite aritmetički znak ili 'Sve' za sve operacije: ");
        string operacija = Console.ReadLine();

        if (operacija.Equals("Sve", StringComparison.OrdinalIgnoreCase))
        {
            IspisiSveOperacije(broj1, broj2);
        }
        else
        {
            IzvrsiOperaciju(broj1, broj2, operacija);
        }
    }

    static void IzvrsiOperaciju(double a, double b, string znak)
    {
        double rezultat = 0;

        switch (znak)
        {
            case "+":
                rezultat = a + b;
                break;
            case "-":
                rezultat = a - b;
                break;
            case "*":
                rezultat = a * b;
                break;
            case "/":
                if (b != 0)
                {
                    rezultat = a / b;
                }
                else
                {
                    Console.WriteLine("Dijeljenje s nulom nije moguće.");
                    return;
                }
                break;
            case "%":
                if (b != 0)
                {
                    rezultat = a % b;
                }
                else
                {
                    Console.WriteLine("Modul s nulom nije moguć.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Nepoznat aritmetički znak.");
                return;
        }

        Console.WriteLine($"Rezultat {a} {znak} {b} = {rezultat}");
    }

    static void IspisiSveOperacije(double a, double b)
    {
        Console.WriteLine($"Sve aritmetičke operacije za brojeve {a} i {b}:");
        IzvrsiOperaciju(a, b, "+");
        IzvrsiOperaciju(a, b, "-");
        IzvrsiOperaciju(a, b, "*");
        IzvrsiOperaciju(a, b, "/");
        IzvrsiOperaciju(a, b, "%");
    }
}
