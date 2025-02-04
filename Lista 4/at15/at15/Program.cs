
using System;

namespace at15
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Você deseja cancelar a operação? ");
			string verifica = Console.ReadLine();
			if(verifica.ToLower() == "nao" || verifica.ToLower() == "não"){
				Console.WriteLine("Por favor, confirme o cancelamento da operação");
			}
		}
	}
}