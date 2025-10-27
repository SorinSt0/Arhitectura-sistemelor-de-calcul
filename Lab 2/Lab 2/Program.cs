using System;

class Program
{
    static void Main()
    {
        string cifre = "0123456789ABCDEF";
        Console.Write("Baza principala: ");
        int b1 = int.Parse(Console.ReadLine());
        Console.Write("Baza dorita: ");
        int b2 = int.Parse(Console.ReadLine());
        Console.Write("Număr: ");
        string n = Console.ReadLine().ToUpper();

        string[] p = n.Split('.');
        double val = 0;

        foreach (char c in p[0])
            val = val * b1 + cifre.IndexOf(c);

        if (p.Length > 1)
        {
            double f = 1.0 / b1;
            foreach (char c in p[1])
            {
                val += cifre.IndexOf(c) * f;
                f /= b1;
            }
        }

        int parteInt = (int)val;
        double parteFrac = val - parteInt;
        string rez = parteInt == 0 ? "0" : "";

        while (parteInt > 0)
        {
            rez = cifre[parteInt % b2] + rez;
            parteInt /= b2;
        }

        if (parteFrac > 0)
        {
            rez += ".";
            for (int i = 0; i < 6 && parteFrac > 0; i++)
            {
                parteFrac *= b2;
                int cifra = (int)parteFrac;
                rez += cifre[cifra];
                parteFrac -= cifra;
            }
        }

        Console.WriteLine($"Rezultat: {rez}");
    }
}