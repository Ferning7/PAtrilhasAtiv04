
using System;

namespace at06
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Deseja adicionar açúcar ou leite ao seu café?");
			string adicional = Console.ReadLine();
			
			if (adicional == "açúcar") {
				Console.WriteLine("Café com açúcar preparado!");
			} else if (adicional == "leite"){
				Console.WriteLine("Café com leite preparado!");
			}
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}