using System;

namespace Locomotiva
{   
    //Tela principal, resumo em da situação geral
    class quadro_geral
    {
        static void Main()
        {
            Console.WriteLine("\n  Locomotiva\n________________\n\n");



            //Condição atual dos recursos
            recursos_locomotiva.display_recursos_locomotiva();


            //Condição física da locomotiva em geral
            status_locomotiva.display_status_locomotiva();
            
        }
    }






    public class status_locomotiva
    {
        public bool acesa;
        public int  cilindro, quadro_eletrico, farol_frontal,luzes_cabine;
        public int  quant_rodas, roda_1, roda_2,roda_3,roda_4, roda_5, roda_6;
        status_locomotiva()
        {
            acesa = false;
            cilindro = 100;
            quadro_eletrico = 100;
            farol_frontal = 100;
            luzes_cabine = 100;
            quant_rodas = 6;
            roda_1 = 100;
            roda_2 = 100;
            roda_3 = 100;
            roda_4 = 100;
            roda_5 = 100;
            roda_6 = 100;
            
        }
        public static void display_status_locomotiva()
        {
            status_locomotiva info_gerais = new status_locomotiva();
            Console.WriteLine("\n\n\n\n");
            Console.WriteLine("--------Informações gerais-------\n");

            Console.Write("Estado da fornalha: ");
            Console.WriteLine(info_gerais.acesa);
            Console.WriteLine("- - - - - - - - - - - - -\n");

            Console.Write("Condições do cilindro: ");
            Console.WriteLine(info_gerais.cilindro);
            Console.WriteLine("- - - - - - - - - - - - - -\n");
            
            Console.Write("Situação elétrica geral: ");
            Console.WriteLine(info_gerais.quadro_eletrico);
            Console.WriteLine("- - - - - - - - - - - - - - -\n");

            Console.Write("Situação elétrica: Farol Frontal: ");
            Console.WriteLine(info_gerais.farol_frontal);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - -\n");

            Console.Write("Situação elétrica: Luzes da cabine: ");
            Console.WriteLine(info_gerais.luzes_cabine);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - -\n");

            Console.Write("Situação mecânica; Quantidade de Rodas Ativadas: ");
            Console.WriteLine(info_gerais.quant_rodas);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - -\n");
            

            Console.WriteLine("Situação mecânica: Estado Físico Individual das Rodas");
            Console.WriteLine("Lado direto    -      Lado esquerdo");
            Console.Write("Roda 1: " + info_gerais.roda_1);
            Console.WriteLine("           Roda 2: " + info_gerais.roda_2);

            Console.Write("Roda 3: " + info_gerais.roda_2);
            Console.WriteLine("           Roda 4: " + info_gerais.roda_2);
            
            Console.Write("Roda 5: " + info_gerais.roda_2);
            Console.WriteLine("           Roda 6: " + info_gerais.roda_2);

            
            Console.ReadKey();
        }
    }
    





    public class recursos_locomotiva
    {
        public int carvao, fogo,agua,vapor;
        public recursos_locomotiva()
        {   
           carvao   = 0;
           fogo     = 0;
           agua     = 0;
           vapor    = 0;
        }
        public static void display_recursos_locomotiva()
        {
            recursos_locomotiva  quant_rec = new  recursos_locomotiva();
            
            Console.WriteLine("---------RECURSOS---------");

            Console.Write("\nQuantidade de carvão -> ");
            Console.WriteLine(quant_rec.carvao);

            Console.Write("\nIncremento do fogo   -> ");
            Console.WriteLine(quant_rec.fogo);

            Console.Write("\nNivel da água        -> ");
            Console.WriteLine(quant_rec.agua);


            Console.Write("\nPressão do vapor     -> ");
            Console.WriteLine(quant_rec.vapor);
            
            Console.WriteLine("\n--------------------------");
            Console.ReadKey();
        }
    }
}






/*
===== Teste de gasto! ======
using System;

namespace intro1
{
	
	class gastar
	{
		static void Main()
		{
			bool loop1 = true;
			int decisao = 0, km = 0, destino = 100;
			recursos obj = new recursos();
			
			while(loop1)
			{

				Console.WriteLine("Para mover para frente digite 1");
				decisao = int.Parse(Console.ReadLine());
				if(decisao == 1)
				{
					km++;
					obj.vapor = obj.vapor - 2;
					destino--;
					Console.WriteLine("Você avançou {0} kilometros", km);
					Console.WriteLine("Você tem {0} de pressão em vapor no cilindro", obj.vapor);
					Console.WriteLine("-->Aperte uma tecla para continuar");
					Console.ReadKey();
					Console.Clear();
				}
				
				
			}


		}
	}

	public class recursos
	{
		public int vapor;
		
		public recursos()
		{
			vapor = 100;
		}

				
	}

}
