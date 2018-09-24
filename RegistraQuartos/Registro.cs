using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistraQuartos
{
    class Registro
    {
        public int[] Quarto = new int[]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        public string[] Nome = new string[10];
        public string[] Email = new string[10];
        public int[] QuartosEscolhidosArray = new int[10];
        public int N,EscolhaDoQuarto,NumeroQuartosEscolhidos,ContaRegistros = 0,EnquantoRegistraQuarto = 1,ContaRegistrosQuartos = -1, ContaRegistrosDados = -1;
        public string EscolheSeQuerRegistrarMais;

        
        
        public void RegistraQuarto()
        {
            while (EnquantoRegistraQuarto == 1)
            {
                ContaRegistrosQuartos++;
                ContaRegistros++;
                ContaRegistrosDados++;
            //Mostra todos os quartos

            Console.Write("Quartos disponíveis: ");
            for (int i = 0; i < Quarto.Length; i++)
            {
                Console.Write(Quarto[i]+"  ");
            }

            Console.WriteLine("");
            Console.Write("Qual quarto deseja registrar?");
            EscolhaDoQuarto = int.Parse(Console.ReadLine());

                //guardando o quarto escolhido
                QuartosEscolhidosArray[ContaRegistrosQuartos] = EscolhaDoQuarto;

            //Procurando qual array é igual ao digitado para retirar da lista
                bool escolha = false;
            int es = EscolhaDoQuarto;
            for (int e = 0; escolha == false; e++)
            {
                if (Quarto[e] == es)
                {

                    Quarto = Quarto.Where(item => item != es).ToArray();
                    escolha = true;


                }

            }

            Console.Write("Nome: ");
            Nome[ContaRegistrosDados] = Console.ReadLine();

            Console.Write("Email: ");
            Email[ContaRegistrosDados] = Console.ReadLine();


               
            Console.WriteLine("Deseja registrar mais quartos? \nS (sim)\nN (Não)");
                EscolheSeQuerRegistrarMais = Console.ReadLine();

                if (EscolheSeQuerRegistrarMais != "s")
                {
                    EnquantoRegistraQuarto = 0;
                }
            }

        }

        //Verificando quantos quartos disponíveis
        public void QuartosDisponiveis()
        { 
                Console.WriteLine("Quartos diponíveis:");

                for (int i = 0; i < Quarto.Length; i++)
                {
                    Console.Write(Quarto[i] + "  ");
                }
            Console.WriteLine("");

        }

        public void Registra() {

            //Deixando Todos os quartos Disponíveis
            

            //Registrando todos os dados necessários e exibindo quantos quartos estão disponíveis para saber qual registrar     
                

           


                Console.WriteLine("");
            



               

        }




        public void MostraRegistros()
        {
            int quartosEscolhidos = EscolhaDoQuarto;

            Console.WriteLine("Quartos Reservados:");


            for (int i = 0; i < ContaRegistros; i++){                

                    Console.Write(QuartosEscolhidosArray[i] + "  ");
                }
                Console.WriteLine("");
            }




        
        public void ReservasRegistradas()
        {
            int iq = 1;
            for (int i = 0; i < ContaRegistros; i++)
            {



                Console.WriteLine("Dados da " + iq + "° reserva");
                Console.WriteLine("Quarto: " + this.QuartosEscolhidosArray[i]);
                Console.WriteLine("Nome: " + this.Nome[i]);
                Console.WriteLine("Email: " + this.Email[i]);
                
                Console.WriteLine("");

                ++iq;
            }
        }


        public void ExcluirReserva(int reservaASerExcluida)
        {
            int iq = 1;
            for (int i = 0; i < ContaRegistros; i++)
            {



                Console.WriteLine("Dados da " + iq + "° reserva");
                Console.WriteLine("Quarto: " + this.QuartosEscolhidosArray[i]);
                Console.WriteLine("Nome: " + this.Nome[i]);
                Console.WriteLine("Email: " + this.Email[i]);

                Console.WriteLine("");

                ++iq;
            }

            /*if (reservaASerExcluida == )
            {

            }
            ContaRegistros -= 1;
            this.QuartosEscolhidosArray[i]);
            this.Nome[i]);
            this.Email[i]);*/
        }



    }
}
