
using System;

namespace at09
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite o primeiro número: ");
			int num1 = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Digite o segundo número: ");
			int num2 = int.Parse(Console.ReadLine());
			
			
			Console.WriteLine((num1 % num2 == 0)? "é divisível" : "Não é divisivel");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}