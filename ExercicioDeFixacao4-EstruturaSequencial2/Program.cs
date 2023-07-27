using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("--- CALCULANDO A ÁREA DE UM CÍRCULO ---");
        Console.WriteLine();

        Console.WriteLine("Qual o raio do círculo? ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Sempre lembrar de usar CultureInfo.InvariantCulture quando for inputar dados pelo teclado.

        double pi = 3.14159;

        double area = pi * Math.Pow(raio, 2);

        Console.WriteLine("A área do raio é " + area.ToString("f4", CultureInfo.InvariantCulture));

    }
}