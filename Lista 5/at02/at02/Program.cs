
using System;

namespace at02
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite o primeiro número: ");
			int num1 = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Digite o segundo número: ");
			int num2 = int.Parse(Console.ReadLine());
			
			Console.WriteLine((num1 > num2) ? "O primeiro número é maior" : "O segundo número é maior");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}