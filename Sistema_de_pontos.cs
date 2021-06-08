//Ranking
using System;

class proa
{
	static void Main(){

		string[] nome = new string[5];
		int[] pontos = new int[5];
		int loop = 0;
		
		
		
		
		
		while(loop < 2)
		{
			
			Console.WriteLine("Digite seu nome");
			
			nome[loop] = Console.ReadLine();
			
			
			retorno:
			Console.WriteLine("Digite sua pontuação");
			
			try
			{
				pontos[loop] = int.Parse(Console.ReadLine());
			}
			
			catch(Exception)
			{
				Console.WriteLine("---------------------");
				Console.WriteLine("Digite Apenas Numeros");
				Console.WriteLine("---------------------\n\n");
				
				
				goto retorno;
			}
	
			Console.WriteLine("\n\n");
			
			
			
			loop++;
		}
		loop = 0;
		
		
		Console.Clear();
		
		Console.WriteLine("\n\n\n===================================");
		Console.WriteLine("	  TABELA DE PONTOS");
		Console.WriteLine("===================================\n\n\n");
		
		Console.WriteLine("	  Nome          Pontos");
		Console.WriteLine("-----------------------------------");
		while(loop < 2)
		{
			
			
			Console.Write("    	 {0}",nome[loop]);
			Console.Write("  	   {0}",pontos[loop]);
			Console.WriteLine("");
			
			
			loop++;	
			
		}
		Console.WriteLine("-----------------------------------");
		
		
		Console.ReadKey();
		
		
		
	
	} 
}

