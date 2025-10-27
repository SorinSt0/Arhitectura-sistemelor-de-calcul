class Program
{
    static void Main()
    {
        Console.Write("Introduceti numărul: ");
        string n = Console.ReadLine();
        Console.Write("Introduceti baza sursă (2-16): ");
        int bazan = int.Parse(Console.ReadLine());

        Console.Write("Introduceti baza tintă (2-16): ");
        int bazadorita = int.Parse(Console.ReadLine());

        try
        {
            int numarInBaza10 = Convert.ToInt32(n, bazan);
            string rezultat = Convert.ToString(numarInBaza10, bazadorita).ToUpper();

            Console.WriteLine($"Numărul {n} din baza {bazan} = {rezultat} în baza {bazadorita}");
        }
        catch
        {
            Console.WriteLine("Eroare: număr invalid pentru baza introdusă!");
        }
        Console.ReadLine();
    }
}
