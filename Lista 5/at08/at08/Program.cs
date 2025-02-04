
using System;

namespace at08
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite uma palavra: ");
			string palavra = Console.ReadLine();
			
			
			int numPalavra = palavra.Length;
			
			Console.WriteLine(numPalavra);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}