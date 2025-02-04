
using System;

namespace at11
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Você é um robô? ");
			string verify = Console.ReadLine();
			
			if (verify.ToLower() == "não" ) {
				Console.WriteLine("Por favor, prove que você não é um robô");
			} 
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}