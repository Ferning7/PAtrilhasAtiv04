
using System;

namespace at01
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Insira sua idade: ");
			int idade = int.Parse(Console.ReadLine());
			
			Console.WriteLine("Possui carteira de motorista?");
			bool resposta = Console.ReadLine().ToLower() == "sim";
			
			
			Console.WriteLine((resposta == "sim" && idade >= 18)? "Pode dirigir" : "Não pode dirigir");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}