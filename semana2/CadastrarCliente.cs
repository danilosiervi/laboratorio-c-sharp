using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira seu nome:");
        string? nome = Console.ReadLine();

        Console.WriteLine("\nInsira seu email:");
        string? email = Console.ReadLine();

        Console.WriteLine("\nOl�, {0}! Usu�rio {1} cadastrado!", nome, email);

        Console.WriteLine("\nAperte enter para encerrar ...");
        Console.ReadLine();
    }
}
