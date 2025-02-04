
using System;

namespace at07
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Insira um número inteiro: ");
			int num = int.Parse(Console.ReadLine());
			
			if (num % 3 == 0 || num % 5 == 0) {
				Console.WriteLine("O número é divisível por 3 ou 5!");
			} else {
				Console.WriteLine("O número não é divisível por 3 ou 5!");
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}