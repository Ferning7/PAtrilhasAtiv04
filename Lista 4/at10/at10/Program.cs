
using System;

namespace at10
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número inteiro: ");
			int num = int.Parse(Console.ReadLine());
			
			if (num > 10 || num < 0) {
				Console.WriteLine("Número inválido!");
			} else {
				Console.WriteLine("Número valido");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}