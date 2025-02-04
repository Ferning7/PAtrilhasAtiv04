
using System;

namespace at07
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número: ");
			int num = int.Parse(Console.ReadLine());
			
			Console.WriteLine((num > 0) ? "Positivo" : "Negativo");
			Console.WriteLine((num == 0) ? "É zero" : "");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}