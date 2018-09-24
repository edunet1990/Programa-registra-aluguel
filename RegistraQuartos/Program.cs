using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RegistraQuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            bool escolha = true;
            Registro R = new Registro();
            int varExcluiReerva;

            // Console.Write("Quantos aluguéis serão registrados? ");
            // R.N = int.Parse(Console.ReadLine());

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>> Bem vindo ao programa Registra Quarto <<<<<<<<<<<<<<<<<<");
            Console.WriteLine("");

            Console.WriteLine("Início");
            Console.WriteLine("");
            

            //R.Escolha(R.N);

            while (escolha)
            {
                
                Console.WriteLine("............................");
                Console.WriteLine("");
                Console.WriteLine("1 - Registrar um Quarto");
                Console.WriteLine("2 - Quartos Disponíveis");
                Console.WriteLine("3 - Quartos Reservados");
                Console.WriteLine("4 - Reservas Registradas");
                Console.WriteLine("5 - Excluir Reserva");
                Console.WriteLine("6 - Sair");
                Console.WriteLine("");
                Console.WriteLine("............................");
                

                R.N = int.Parse(Console.ReadLine());

                switch (R.N)
                {
                    case 1:
                        R.RegistraQuarto();
                        
                        break;

                        case 2:
                        R.QuartosDisponiveis();

                        break;

                    case 3:
                        R.MostraRegistros();

                        break;

                    case 4:
                        R.ReservasRegistradas();

                        break;

                    case 5:
                        int iq = 1;
                        
                        for (int i = 0; i < R.ContaRegistros; i++)
                        {



                            Console.WriteLine("Dados da " + iq + "° reserva");
                            Console.WriteLine("Quarto: " + R.QuartosEscolhidosArray[i]);
                            Console.WriteLine("Nome: " + R.Nome[i]);
                            Console.WriteLine("Email: " + R.Email[i]);

                            Console.WriteLine("");
                            ++iq;
                        }


                        Console.Write("Qual reserva deseja excluir? ");
                        varExcluiReerva = int.Parse(Console.ReadLine());
                        --varExcluiReerva; //para se igualar aos elementos do array ex: se digitou 1 o elemento correspondente no array é 0
                        R.ExcluirReserva(varExcluiReerva);
                        break;

                    case 6:
                        Environment.Exit(0);
                        break;
                }
            }
            

            Console.ReadKey();

        }
    }
}
