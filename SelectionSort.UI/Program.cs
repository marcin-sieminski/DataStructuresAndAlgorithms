using SelectionSort.Library;
using System.Diagnostics;
using SelectionSort.UI;

var continueRun = true;

do
{
    Console.Clear();
    Console.WriteLine("Aplikacja demonstracyjna algorytmu sortowania przez wybieranie");
    Console.WriteLine("\nProszę wybrać opcję:\n");
    Console.WriteLine("1. Przykład sortowania na tablicy liczb całkowitych");
    Console.WriteLine("2. Przykład sortowania na tablicy liczb rzeczywistych");
    Console.WriteLine("3. Przykład sortowania na tablicy ciągów znakowych");
    Console.WriteLine("4. Uruchomienie testów");
    Console.WriteLine("5. Powrót do systemu");

    var keyPressed = Console.ReadKey();


    switch (keyPressed.KeyChar)
    {
        case '1':
            Console.Clear();
            Console.WriteLine("Przykład sortowania na tablicy liczb całkowitych.");
            var arrayInt = new[] { 5, 2, 0 };
            Console.WriteLine("\nPrzed sortowaniem:");
            PrintItems(arrayInt);
            Console.WriteLine();
            SelectionSortHelper.Sort(arrayInt);
            Console.WriteLine("\nPo sortowaniu:");
            PrintItems(arrayInt);
            Console.WriteLine("\n\nNaciśnij ENTER aby kontynuować.\n");
            Console.ReadKey();
            break;
        case '2':
            Console.Clear();
            Console.WriteLine("Przykład sortowania na tablicy liczb rzeczywistych.");
            var arrayDouble = new[] { 155.5, -5656.02, 15656.22, -2000.0 };
            Console.WriteLine("\nPrzed sortowaniem:");
            PrintItems(arrayDouble);
            Console.WriteLine();
            SelectionSortHelper.Sort(arrayDouble);
            Console.WriteLine("\nPo sortowaniu:");
            PrintItems(arrayDouble);
            Console.WriteLine("\n\nNaciśnij ENTER aby kontynuować.");
            Console.ReadKey();
            break;
        case '3':
            Console.Clear();
            Console.WriteLine("Przykład sortowania na tablicy ciągów znakowych.");
            var arrayString = new[] { "Marek", "Anna", "Wioletta", "Zenon", "Grzegorz", "Jerzy", "Adam" };
            Console.WriteLine("\nPrzed sortowaniem:");
            PrintItems(arrayString);
            Console.WriteLine();
            SelectionSortHelper.Sort(arrayString);
            Console.WriteLine("\nPo sortowaniu:");
            PrintItems(arrayString);
            Console.WriteLine("\n\nNaciśnij ENTER aby kontynuować.");
            Console.ReadKey();
            break;
        case '4':
            Console.Clear();
            Console.WriteLine("Trwa uruchamianie testów...");
            var directory = Helpers.TryGetSolutionDirectoryInfo();
            if (directory != null)
            {
                var path = Path.Combine(directory.FullName, @"SelectionSort.Tests\\SelectionSort.Tests.csproj");
                var process = Process.Start("dotnet", @$"test {path} --logger ""console;verbosity=detailed""");
                process.WaitForExit();
            }
            Console.WriteLine("\n\nNaciśnij ENTER aby kontynuować.");
            Console.ReadKey();
            break;
        case '5':
            Console.Clear();
            Console.WriteLine("Wybrano powrót do systemu.");
            continueRun = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Wybrano nieprawidłową opcję.");
            Console.WriteLine("Naciśnij ENTER aby kontynuować.");
            Console.ReadKey();
            break;
    }
} while (continueRun);

void PrintItems<T>(T[] array)
{
    Console.Write("[ ");
    for (var index = 0; index < array.Length; index++)
    {
        var item = array[index];
        Console.Write($"{item}");
        if (index < array.Length - 1)
        {
            Console.Write(" | ");
        }
    }
    Console.WriteLine(" ]");
}

