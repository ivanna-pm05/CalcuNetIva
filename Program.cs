using System.Globalization;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Calculadora!");

        decimal value = 123.456m;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine($"{value.ToString("C3", new CultureInfo("en-US"))}");
        Console.WriteLine($"{value.ToString("C", new CultureInfo("fr-FR"))}");
        Console.WriteLine($"{value.ToString("C", new CultureInfo("ja-JP"))}");
        Console.WriteLine($"${value.ToString("C3", new CultureInfo("en-US"))}");
        Console.WriteLine($"{value.ToString("C3", new CultureInfo("fr-FR"))}");
        Console.WriteLine($"{value.ToString("C3", new CultureInfo("ja-JP"))}");
        Console.WriteLine($"-${value.ToString("C3", new CultureInfo("en-US"))}");
        Console.WriteLine($"-{value.ToString("C3", new CultureInfo("fr-FR"))}");
        Console.WriteLine($"-{value.ToString("C3", new CultureInfo("ja-JP"))}");

    }
}