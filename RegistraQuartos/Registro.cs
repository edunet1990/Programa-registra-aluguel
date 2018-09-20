using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistraQuartos
{
    class Registro
    {
        public int[] Quarto = new int[10];
        public string[] Nome = new string[10];
        public string[] Email = new string[10];
        public int[] QuartosEscolhidosArray = new int[10];
        public int N,EscolhaDoQuarto,NumeroQuartosEscolhidos;

        

        public void Registra(int n) {

            //Deixando Todos os quartos Disponíveis
            for (int i = 1; i < 10; i++)
            {
                Quarto[i] = i;
            }


            //Verificando quantos quartos disponíveis
            void QuartosDisponiveis()
            {

                Console.WriteLine("Quartos diposníveis:");

                for (int i = 1; i < Quarto.Length; i++)
                {
                    Console.Write(Quarto[i] +", ");
                }
                
            }

            void RetirandoOQuartoDaLista()
            {
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
            }




            //Registrando todos os dados necessários e exibindo quantos quartos estão disponíveis para saber qual registrar
            for (int i = 0; i< n; i++)
            {
                Console.Write("Nome: ");
                Nome[i] = Console.ReadLine();

                Console.Write("Email: ");
                Email[i] = Console.ReadLine();


                QuartosDisponiveis();
                Console.Write("Qual Quarto? ");
                EscolhaDoQuarto = int.Parse(Console.ReadLine());
                QuartosEscolhidosArray[i] = EscolhaDoQuarto;
                
                RetirandoOQuartoDaLista();


                Console.WriteLine("");

                NumeroQuartosEscolhidos++;

            }



        }




        public void MostraRegistros(int qtdQuartosRegistrados)
        {
            int quartosEscolhidos = EscolhaDoQuarto;
            int iq = 1;
            for (int i = 0; i < NumeroQuartosEscolhidos; i++)
            {
                
                
                Console.WriteLine("Dados do " + iq + "° aluguel");
                Console.WriteLine("Nome: "+this.Nome[i]);
                Console.WriteLine("Email: "+this.Email[i]);
                Console.WriteLine("Quarto: "+this.QuartosEscolhidosArray[i]);
                Console.WriteLine("");

                ++iq;
            }


            Console.WriteLine("Quartos ocupados: ");


            for (int i = 0; i < NumeroQuartosEscolhidos; i++)
            {
                
                Console.WriteLine(this.QuartosEscolhidosArray[i] + ": "+
                    this.Nome[i]+", " +
                    this.Email[i]);
            }
        }



    }
}
