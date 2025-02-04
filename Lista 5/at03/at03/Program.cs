
using System;

namespace at03
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			Console.WriteLine("Escolha uma lista, 1 ou 2:");
			int escolha = int.Parse(Console.ReadLine());
			
			if (escolha == 1) {
				// cria a lista 1
				int[] numeros = {1, 2, 3, 4, 5}; 
				
				Console.WriteLine("Lista 1: ");
				
				// imprime a lista 1
				for (int i = 0; i < numeros.Length; i++) {
					Console.WriteLine(numeros[i]);
				}
				Console.WriteLine((numeros.Length == 0)? "É vazia" : "Não está vazia");
				
			} else if (escolha == 2) {
				// cria a lista 2
				int[] numeros = {};
				
				// imprime a lista 2
				Console.WriteLine("Lista 2: ");
				for (int i = 0; i < numeros.Length; i++){
					Console.WriteLine(numeros[i]);
				}
				Console.WriteLine((numeros.Length == 0)? "É vazia" : "Não está vazia");
			}
			
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}