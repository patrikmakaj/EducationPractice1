// 7.	Napisati program koji na temelju unesene riječi izbacuje količinu samoglasnika u istoj rečenici. Ispisati broj samoglasnika
public class Zadatak7
{
    public static void Run()
    {
        Console.Write("Unesite riječ: ");
        string word = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(word))
        {
            Console.WriteLine("Unesena riječ je prazna.");
            return;
        }

        int vowelCount = CountVowels(word);

        Console.WriteLine($"Broj samoglasnika u riječi '{word}': {vowelCount}");
    }

    static int CountVowels(string input)
    {
        string vowels = "aeiouAEIOU";
        int count = 0;

        foreach (char c in input)
        {
            if (vowels.Contains(c))
            {
                count++;
            }
        }

        return count;
    }
}
