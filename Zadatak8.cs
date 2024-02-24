// 8.	https://www.w3schools.com/cs/cs_files.php (potrebno malo istraživi ovaj link, vezan je uz rad s fileovima, dokumentima i slično)
// napisati zadatak koji stvara nekakav .txt file, te drugi zadatak koji zapravo čita iz tog file-a.
public class Zadatak8
{
    public static void Run()
    {
        string filePath = "patrikmakaj.txt";
        string content = "Patrik Makaj je rođen u Našicama";
        CreateWriteReadAndPrintTextFile(filePath, content);
    }

    static void CreateWriteReadAndPrintTextFile(string filePath, string content)
    {
        try
        {
            File.WriteAllText(filePath, content);

            string readContent = File.ReadAllText(filePath);

            Console.WriteLine($"Tekst iscitan iz {filePath}:\n{readContent}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
