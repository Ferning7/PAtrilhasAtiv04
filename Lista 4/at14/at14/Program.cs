
using System;

namespace at14
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite uma palavra: ");
			string palavra = Console.ReadLine();
			
			if (palavra.Length != 0) {
				Console.WriteLine("A palavra não é vazia");
			} else {
				Console.WriteLine("é vazia");
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}