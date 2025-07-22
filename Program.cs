using System;
internal class Program
{
    private static void Main(string[] args)
    {
        /* Console.WriteLine("Calculadora!");

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
        Console.WriteLine($"-{value.ToString("C3", new CultureInfo("ja-JP"))}"); */

        Console.WriteLine("Welcome to the calculator divisa!");
        Console.WriteLine("1. Convertir Dolares a Pesos colombianos");
        Console.WriteLine("2. Convertir Dolares a Euros");
        Console.WriteLine("3. Convertir Dolares a ienes japoneses");
        Console.WriteLine("4. Salir");

        Console.WriteLine("Ingrese su nombre:");
        string nombre = Console.ReadLine();


        byte edad = 0;
        Console.WriteLine("Ingrese su edad:");
        edad = Convert.ToByte(Console.ReadLine());
        Console.WriteLine($"Hola {nombre}, tienes {edad} años.");
    }
}