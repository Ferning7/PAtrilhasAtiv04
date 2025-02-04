
using System;

namespace at04
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Digite uma palavra: ");
			string palavra = Console.ReadLine();
			
			Console.WriteLine((palavra.Length == 0)? "essa string está vazia" : "esta string não está vazia");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}