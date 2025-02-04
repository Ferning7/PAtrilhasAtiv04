
using System;

namespace at06
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Digite um número: ");
			int num = int.Parse(Console.ReadLine());
			
			Console.WriteLine((num > 0) ? "Absoluto": "Não absoluto");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}