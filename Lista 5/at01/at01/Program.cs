
using System;

namespace at01
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite um número: ");
			int num = int.Parse(Console.ReadLine());
			
			Console.WriteLine((num % 2 == 0)?"Par" : "Ímpar");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}