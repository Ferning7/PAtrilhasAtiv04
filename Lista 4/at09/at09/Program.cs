
using System;

namespace at09
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Digite seu nome: ");
			string nome = Console.ReadLine();
			
			if (nome == "Wilson" || nome == "Gloria") {
				Console.WriteLine("Olá, bem vindo(a) de volta!");
			} else {
				Console.WriteLine("Acesso negado");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}