
using System;

namespace at04
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Você é assinante de Senai Flix?");
			bool assinatura = Console.ReadLine().ToLower() == "sim";
			
			Console.WriteLine("Já assistiu à serie 'The Walking Dead'? ");
			bool resposta = Console.ReadLine().ToLower() == "sim";
			
			Console.WriteLine((assinatura == true && resposta == true)?"Ótimo, agora você pode assistir à nova temporada!" : "Não pode assistir à nova temporada");
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}