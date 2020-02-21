/*Esse questionário permite ao usuário a criação de sua próprias
perguntas e respostas. (45% concluído)

!!!!!!CONTÉM ERROS A PARTIR DA DECLARAÇÃO DAS RESPOSTAS!!!!!!!!!!!!!!!!

Atualizações:
Adicionado tratamento de erro em todas as entradas de pergutas (try, catch)
Adicionado a opção de alteração de perguntas
Iniciado o desenvolvimento da interface em console
Iniciado a sessão de respostas vinculadas à perguntas
*/ 

using System;


class project
{	
	
	static void Main()
	{
		
		string[] perguntas = new string[101];
		string[] respostas = new string[101];
		
		//numero de perguntas do usuário
		int NumPerg = 0;
		
		//numero de perguntas respostas para cada pergunta
		int NumResp = 0;
		
		int ContadorDeRespostas = 0;
		
		//contador
		int Cont = 1;
		
		// Altercação de perguntas
		int alteracao = 1;
		
		

		//Executar um loop
		bool retorno = true;
		
		//goto avancar;
		
		
		
		
		//Inicio
		Console.Clear();
		Console.WriteLine("===============================================");
		Console.WriteLine("- Esse questionário é a  versão mais  recente -");
		Console.WriteLine("- do antigo que foi feito em C++              -");
		Console.WriteLine("-\n- Com ele  o entrevistador  pode  montar as   -");
		Console.WriteLine("- suas perguntas  e  também  suas  respostas  -");
		Console.Write("===============================================\n\n");
		Console.Write("\nPressione qualquer tecla para iniciar\n");
		Console.ReadKey();
		

		// Ponto de retorno do erro de entrada
		retorno:
		Console.Clear();
		
		
		Console.WriteLine("=================================================");
		Console.WriteLine("Você deve especificar em números a quantidade");
		Console.WriteLine("(A quantidade máxima aceita é de 100 perguntas)");
		Console.WriteLine("=================================================\n\n");
		Console.Write("  Quantas perguntas deseja fazer?\n\n-\n-\n-\n-> ");
		
		
		
		try //Tratamento de erros, Exception;
		{
			NumPerg = int.Parse(Console.ReadLine()); //Aqui é definido a quantidade de perguntas
			if(NumPerg <= 0 || NumPerg > 100){
				Console.WriteLine("------------------------------------");
				Console.WriteLine("Os números válidos são entre 1 à 100");
				Console.WriteLine("------------------------------------");
				Console.WriteLine("	Pressione uma tecla");
				Console.ReadKey();
				//goto retorno;		
			}
		}	
		catch (Exception)
		{
			Console.Clear();
			Console.WriteLine("\n");
			Console.WriteLine(" ++++++++ATENÇÃO+++++++");
			Console.WriteLine(" + Use apenas numeros +");
			Console.WriteLine(" ++++++++++++++++++++++");
			Console.WriteLine("\n");
			
			Console.WriteLine("  Pressione uma tecla");
			Console.ReadKey();
			
			
			goto retorno;
			
		}
		
		
		
		
		//Limpa a tela e começa o loop para receber as perguntas
		Console.Clear();
		for(int i = 1; i <= NumPerg; i++) 
		{ 
			Console.WriteLine("=======================");
			Console.WriteLine("= Digite sua pergunta =");
			Console.WriteLine("=======================");
			Console.WriteLine("\n-\n-\n-\n-\n");
			
			Console.Write(">> ");
			perguntas[i] = Console.ReadLine();
			
			Console.Clear();
			Console.WriteLine("---------------------------------------");
			Console.WriteLine("-  A pergunta número {0} foi armazenada -", i);
			Console.WriteLine("---------------------------------------\n\n");
			
			
		}




		//Desmostra as perguntas feitas
		Console.Clear();
		Console.WriteLine("========================================");
		Console.WriteLine("= Todas as perguntas foram registradas ="); 
		Console.WriteLine("========================================\n\n");
		
		for(int i = 1; i <= NumPerg; i++)
		{	
			Console.WriteLine("_______________________________________\n");
			Console.WriteLine("Pergunta numero {0}:\n\n-> {1}",i,perguntas[i]);
			Console.WriteLine("\n\n");
			
		}

		
	
	
		
		
		

		//Permite ao usuário mudar a sua pergunta
		while(retorno)
		{
			
			
			
			Console.WriteLine("\n\n");
			Console.WriteLine("===========================================");
			Console.WriteLine(" Para alterar alguma pergunta digite apenas"); 
			Console.Write(" o número dela.");
			try
			{
				Console.Write(" Para não alterar nada\n digite 1000 e tecle ENTER\n\n->");
				
				
				alteracao = int.Parse(Console.ReadLine());


				//sai do loop se o usuário não quiser alterar nenhuma pergunta
				if(alteracao == 1000)
				{
					retorno = false;
				} 
				
				
				
				//retorna um erro se o numero inserido não representar uma pergunta
				else if(alteracao < 1 || alteracao > NumPerg )
				{
					Console.WriteLine("+++++++++++++++++++++++++++++++++");
					Console.WriteLine("Use apenas os numeros a partir de");
					Console.Write("1 até {0}. ", NumPerg);
					Console.WriteLine("Ou digite 1000 para sair");
					Console.WriteLine("+++++++++++++++++++++++++++++++++");
					Console.ReadKey();
				}
				
				
				//sai do loop se o usuário inserir um numero que representa uma pergunta
				else 
				{
					retorno = false;
				} 
			}

			//retorna um erro se o usuário não inserir um numero
			catch(Exception)
			{
				
				Console.WriteLine("\n");
				Console.WriteLine(" ++++++++ATENÇÃO+++++++");
				Console.WriteLine(" + Use apenas numeros +");
				Console.WriteLine(" ++++++++++++++++++++++");
				Console.WriteLine("\n");
			
				Console.WriteLine("  Pressione uma tecla");
				
				Console.ReadKey();
				Console.Clear();
				
			}
		}
		
		
		
		
		
		
		
		//Loop para alterar uma pergunta
		while(alteracao <= NumPerg || retorno)
		{	
			try
			{	
				Console.WriteLine("================================");
				Console.Write("= Reescreva a pergunta número {0}:\n\n-> ", alteracao);
				perguntas[alteracao] = Console.ReadLine();
				Console.WriteLine("=================================");
				Console.Write("Para alterar outra pergunta digite\nseu numero.");
				Console.Write(" Para não alterar mais\nnada digite: 1000\n\n-> ");
				alteracao = int.Parse(Console.ReadLine());
				
				if(alteracao == 1000)
				{
					retorno = false;
				}
				
				
				else if (alteracao < 1 || alteracao > NumPerg )
				{
					Console.WriteLine("\n\n+++++++++++++++++++++++++++++++++");
					Console.WriteLine("Use apenas os numeros a partir de");
					Console.WriteLine("1 até {0}", NumPerg);	
					Console.WriteLine("+++++++++++++++++++++++++++++++++\n\n");
				}
				
				
			}
			
			catch(Exception)
			{
				
				Console.WriteLine("\n");
				Console.WriteLine(" ++++++++ATENÇÃO+++++++");
				Console.WriteLine(" + Use apenas numeros +");
				Console.WriteLine(" ++++++++++++++++++++++");
				Console.WriteLine("\n");
			
				Console.WriteLine("  Pressione uma tecla");
				Console.ReadKey();
				
			}
			
			
		}

		
		
		Console.Clear();
		
		//Segunda tabela de perguntas, demonstra as perguntas feitas
		Console.WriteLine("====================================");
		Console.WriteLine("== Perguntas Finalizadas e Salvas ==");
		Console.WriteLine("====================================\n\n");
		
		
		for(int i = 1; i <= NumPerg; i++) 
		{
			
			Console.WriteLine("Pergunta numero {0}:\n\n{1}\n",i,perguntas[i]);
			Console.WriteLine("-------------------------------");
		}
		Console.WriteLine("\nDigite uma tecla para continuar");
		
		Console.ReadKey();
		retorno = true;
		////////////////////////////////////////////////////
		////////////////////////////////////////////////////
		////////////////////////////////////////////////////
		////////////////////////////////////////////////////
		//Respostas////////////////////////////////////////
		
		retorno = true;
		Console.Clear();
		
		Console.WriteLine("=====================================================");
		Console.WriteLine("= Para cada pergunta uma resposta, ou um conjunto   =");
		Console.WriteLine("= de respostas será vinculado à ela. Assim como as  =");
		Console.WriteLine("= perguntas as respostas também podem ser alteradas =");
		Console.WriteLine("=====================================================");
	
		Console.WriteLine("\n	Digite uma tecla para continuar");
		
		Console.ReadKey();
		Console.Clear();
		
		
		
		while(retorno)
		{	
		
			Console.WriteLine("=================================");
			Console.WriteLine("	Para a pergunta:\n\n{0}\n", perguntas[Cont]);
			Console.WriteLine("---------------------------------");
			Console.WriteLine("Quantas respostas ela poderá ter?");
			Console.WriteLine("Digite em números a quantidade. O"  );
			Console.WriteLine("limite  é  de  5  respostas."  );
			Console.WriteLine("---------------------------------");
			Console.Write("-\n-\n-\n-\n-> ");
			
			try
			{
				NumResp = int.Parse(Console.ReadLine());
				
				if(NumResp <= 0 || NumResp > 5)
				{
					Console.WriteLine("+++++++++++++++++++++++++++++++++");
					Console.WriteLine("+ O número inserido não é válido");
					Console.WriteLine("+ O valor deve ser maior que 0");
					Console.WriteLine("+ O valor deve ser menor que 5");
					Console.WriteLine("+++++++++++++++++++++++++++++++++");
					
					Console.WriteLine("Pressione uma tecla para continuar");
					
					Console.ReadKey();
				}
				
				
				else
				{
					retorno = false;
				}
		
		
			
			}
			catch(Exception)
			{
				Console.WriteLine("|++++++++++++++++++++++++++++++++++|");
				Console.WriteLine("| Você deve inserir apenas números |");
				Console.WriteLine("|++++++++++++++++++++++++++++++++++|");
				Console.WriteLine("Pressione uma tecla para continuar");
				Console.ReadKey(); 
			}
			
			
			
	
		}
		
		
		
		
		Cont = 1;
		
		while(Cont < NumPerg)
		{
			Console.WriteLine("==================================");
			
			Console.WriteLine("\n------Para a pergunta----------\n");
			Console.WriteLine(perguntas[Cont]);
			
			while(ContadorDeRespostas <= NumResp)
			{	
				Console.WriteLine("\n  Digite a resposta:");
				Console.Write("-\n-\n-\n-\n-> ");
				respostas[ContadorDeRespostas++] = Console.ReadLine();
				Console.WriteLine("--------------------------------");
				Console.WriteLine("----A resposta {0} foi salva----", ContadorDeRespostas);
				Console.WriteLine("--------------------------------");
				Console.ReadKey();
			}
			
			
			Cont++;
		}
		
		
		
		
		
		
		
		
		
		
		
		//finalização
		
		
		Console.Clear();
		
		Cont = 0 + 1;
		
		ContadorDeRespostas = 0;
		
		while(Cont < NumPerg)
		{
			Console.WriteLine("************************************");
			Console.WriteLine("\nA pergunta numero {0}:", Cont);
			Console.WriteLine("{0}", perguntas[Cont]);
			Console.WriteLine("Tem como resposta as seguintes sentenças:");
			
			while(ContadorDeRespostas <= NumResp)
			{	
				Console.WriteLine(respostas[ContadorDeRespostas++]);
				
			}
			Console.WriteLine("....................................");
			
			Cont++;
		}
		
		
		
		Console.ReadKey();
		
		
	
		
	}

	
	
	
}
