using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¡Bienvenido al programa de operaciones matemáticas!");
        Console.WriteLine("Ingrese dos números enteros para sumar, restar, multiplicar y dividir.");
        Console.Write("Primer número: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nResultados:");
        Console.WriteLine($"Suma: {Suma(num1, num2)}");
        Console.WriteLine($"Resta: {Resta(num1, num2)}");
        Console.WriteLine($"Multiplicación: {Multiplicacion(num1, num2)}");
        Console.WriteLine($"División: {Division(num1, num2)}");
    }

    static int Suma(int a, int b)
    {
        int resultado = a + b;
        Console.WriteLine($"{a} + {b} = {resultado}");
        return resultado;
    }

    static int Resta(int a, int b)
    {
        int resultado = a - b;
        Console.WriteLine($"{a} - {b} = {resultado}");
        return resultado;
    }

    static int Multiplicacion(int a, int b)
    {
        int resultado = a * b;
        Console.WriteLine($"{a} * {b} = {resultado}");
        return resultado;
    }

    static int Division(int a, int b)
    {
        int resultado = a / b;
        Console.WriteLine($"{a} / {b} = {resultado}");
        return resultado;
    }
}