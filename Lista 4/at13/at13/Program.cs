
using System;

namespace at13
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Você é um membro ativo no clube?");
			string atividade = Console.ReadLine();
			
			if (atividade.ToLower() == "nao" || atividade.ToLower() == "não") {
				Console.WriteLine("Por favor, atualize sua inscrição para continuar usufruindo dos benefícios do clube");
			} else {
				Console.WriteLine("Inscrição atualizada");
			}
				
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}