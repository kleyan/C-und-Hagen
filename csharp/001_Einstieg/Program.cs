using System;

namespace Einstieg;

internal static class Program
{
    private static void Main()
    {
        Console.Write("Wie heißt du? ");
        string? name = Console.ReadLine();

        int ersteZahl = 2;
        int zweiteZahl = 3;
        int summe = Addiere(ersteZahl, zweiteZahl);

        Console.WriteLine($"Hallo {name}!");
        Console.WriteLine($"{ersteZahl} + {zweiteZahl} = {summe}");
    }

    private static int Addiere(int a, int b)
    {
        int ergebnis = a + b;
        return ergebnis;
    }
}