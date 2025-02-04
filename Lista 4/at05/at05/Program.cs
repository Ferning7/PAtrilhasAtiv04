
using System;

namespace at05
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite seu nome: ");
			string nome = Console.ReadLine();
			
			Console.WriteLine("Insira sua idade: ");
			int idade = int.Parse(Console.ReadLine());
			
			Console.WriteLine((nome.Length == 3 && idade >= 18)? "Acesso permitido" : "Acesso negado");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}