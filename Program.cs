using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Odaberite zadatak (1-8) ili upišite 'exit' za izlaz:");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                break;
            }

            if (int.TryParse(input, out int taskNumber) && taskNumber >= 1 && taskNumber <= 8)
            {
                Console.WriteLine("\n--------------------------------------");
                Console.WriteLine($"Izabrani zadatak: {taskNumber}");
                Console.WriteLine("--------------------------------------");
                RunSelectedTask(taskNumber);
                Console.WriteLine("--------------------------------------\n");
            }
            else
            {
                Console.WriteLine("Pogrešan unos. Molimo unesite broj od 1 do 8 ili 'exit' za izlaz.");
            }
        }
    }

    static void RunSelectedTask(int taskNumber)
    {
        switch (taskNumber)
        {
            case 1:
                Zadatak1.Run();
                break;
            case 2:
                Zadatak2.Run();
                break;
            case 3:
                Zadatak3.Run();
                break;
            case 4:
                Zadatak4.Run();
                break;
            case 5:
                Zadatak5.Run();
                break;
            case 6:
                Zadatak6.Run();
                break;
            case 7:
                Zadatak7.Run();
                break;
            case 8:
                Zadatak8.Run();
                break;
            default:
                Console.WriteLine("Nepoznat zadatak.");
                break;
        }
    }
}
