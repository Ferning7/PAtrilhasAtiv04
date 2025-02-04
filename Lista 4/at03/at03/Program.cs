
using System;

namespace at03
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Possui diploma de Ensino Superior? ");
			bool diploma = Console.ReadLine().ToLower() == "sim";
			
			Console.WriteLine("Insira sua idade: ");
			int idade = int.Parse(Console.ReadLine());
			
			Console.WriteLine((diploma == true && idade >= 21)? "Parabéns, você está qualificado para a vaga!" : "Você deve atender todos requisitos para qualificar para a vaga");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}