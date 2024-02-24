// 5.	Napisati program koji unosi nekakvu riječ, potrebno je tu riječ preokrenuti u suprotnom redoslijedu (Bok → koB).
public class Zadatak5
{
    public static void Run()
    {
        Console.Write("Unesite riječ: ");
        string word = Console.ReadLine();

        for (int i = word.Length - 1; i >= 0; i--)
        {
            Console.Write(word[i]);
        }

        Console.WriteLine();
    }
}
