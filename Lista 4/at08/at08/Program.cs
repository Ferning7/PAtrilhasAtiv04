
using System;

namespace at08
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Deseja comprar um produto? ");
			string desejo = Console.ReadLine();
			
			if (desejo == "sim" || desejo == "s") {
				Console.WriteLine("Obrigado pela compra!");
			} else {
				Console.WriteLine("Compre!!!!!!!!!!!!!!");
			}
				
				
				Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}