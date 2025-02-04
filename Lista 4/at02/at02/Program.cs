
using System;

namespace at02
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Deseja comprar um carro novo? ");
			bool desejo = Console.ReadLine().ToLower() == "sim";
			
			Console.WriteLine("Tem dinheiro suficiente? ");
			bool dinheiro = Console.ReadLine().ToLower() == "sim";
			
			Console.WriteLine((desejo == true && dinheiro == true)? "Parabéns, você pode comprar um carro novo!" : "Você não pode comprar um carro novo");
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}