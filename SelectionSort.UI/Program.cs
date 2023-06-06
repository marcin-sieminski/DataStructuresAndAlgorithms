using SelectionSort.Library;
using System.Diagnostics;

var continueRun = true;

do
{
    Console.Clear();
    Console.WriteLine("Aplikacja demonstracyjna algorytmu sortowania przez wybieranie\n");
    Console.WriteLine("Proszę wybrać opcję:\n");
    Console.WriteLine("1. Prosty przykład działania");
    Console.WriteLine("2. Zaawansowany przykład działania");
    Console.WriteLine("3. Testy");
    Console.WriteLine("4. Powrót");

    var keyPressed = Console.ReadKey();


    switch (keyPressed.KeyChar)
    {
        case '1':
            Console.Clear();
            Console.WriteLine("Prosty przykład działania.");
            var arraySimple = new[] { 5, 2, 0 };
            Console.WriteLine("\nPrzed sortowaniem:");
            foreach (var item in arraySimple)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            SelectionSortHelper.Sort(arraySimple);
            Console.WriteLine("\nPo sortowaniu:");
            foreach (var item in arraySimple)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\nNaciśnij dowolny klawisz aby kontynuować.\n");
            Console.ReadKey();
            break;
        case '2':
            Console.Clear();
            Console.WriteLine("Zaawansowany przykład działania.");
            var arrayComplex = new[] { 155.5, -5656.02, 15656.22, -2000.0 };
            Console.WriteLine("\nPrzed sortowaniem:");
            foreach (var item in arrayComplex)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
            SelectionSortHelper.Sort(arrayComplex);
            Console.WriteLine("\nPo sortowaniu:");
            foreach (var item in arrayComplex)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\nNaciśnij dowolny klawisz aby kontynuować.");
            Console.ReadKey();
            break;
        case '3':
            Console.Clear();
            Console.WriteLine("Trwa uruchamianie testów.");
            var path = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName, @"SelectionSort.Tests\SelectionSort.Tests.csproj");
            Process.Start("dotnet", @$"test {path} --logger ""console;verbosity=detailed""");
            Console.ReadKey();
            break;
        case '4':
            Console.Clear();
            Console.WriteLine("Wybrano powrót do systemu.");
            continueRun = false;
            break;
        default:
            Console.Clear();
            Console.WriteLine("Wybrano nieprawidłową opcję.");
            Console.WriteLine("Naciśnij dowolny klawisz aby kontynuować.");
            Console.ReadKey();
            break;
    }
} while (continueRun);

