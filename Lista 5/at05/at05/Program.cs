
using System;

namespace at05
{
	class Program
	{
		public static void Main(string[] args)
		{
			// metodo 1 rogerin
			bool escolha = false;
			string check = (escolha == true) ? "É verdadeiro" : "Mintira";
			Console.WriteLine(check);
			
			// metodo 2
			Console.WriteLine("Digite V ou F para verdadeiro ou falso: ");
			string escolha2 = Console.ReadLine();
			
			Console.WriteLine((escolha2.ToUpper() == "V")? "Verdadeiro" : "Falso");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}