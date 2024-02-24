// 6.	Napisati program koji na temelju unosa neke rečenice, izbacuje riječ koja je najduža i najkraća. Potrebno je istu ispisati
public class Zadatak6
{
    public static void Run()
    {
        Console.Write("Unesite rečenicu: ");
        string sentence = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(sentence))
        {
            Console.WriteLine("Unesena rečenica je prazna.");
            return;
        }

        string[] words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        if (words.Length == 0)
        {
            Console.WriteLine("Nema riječi u rečenici.");
            return;
        }

        string shortestWord = words[0];
        string longestWord = words[0];

        foreach (string word in words)
        {
            if (word.Length < shortestWord.Length)
            {
                shortestWord = word;
            }

            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        Console.WriteLine($"Najkraća riječ: {shortestWord}");
        Console.WriteLine($"Najduža riječ: {longestWord}");
    }
}
