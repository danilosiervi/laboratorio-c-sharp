using System;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Usando o la�o for:");
		int soma = 0;

		for (int i = 1; i <= 100; i++)
		{
			soma += i;
		}
		Console.WriteLine(soma);

		Console.WriteLine("\nUsando o la�o while:");

		soma = 0;
		int num = 1;

		while (num <= 100)
		{
			soma += num;
			num++;
		}
		Console.WriteLine(soma);

		Console.WriteLine("\nAperte enter para encerrar ...");
		Console.ReadLine();
	}
}
