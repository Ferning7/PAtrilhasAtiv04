
using System;

namespace at12
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite um número: ");
			int num = int.Parse(Console.ReadLine());
			
			if (num != 0) {
				Console.WriteLine("O número é diferente de 0");
			} else{
				Console.WriteLine("é igual a 0");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}