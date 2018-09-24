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

            // Console.Write("Quantos aluguéis serão registrados? ");
            // R.N = int.Parse(Console.ReadLine());

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>> Bem vindo ao programa Registra Quarto <<<<<<<<<<<<<<<<<<");
            Console.WriteLine("");

            Console.WriteLine("Início");
            Console.WriteLine("");
            

            //R.Escolha(R.N);

            while (escolha)
            {
                Console.WriteLine("1 - Registrar um Quarto");
                Console.WriteLine("2 - Quartos Disponíveis");
                Console.WriteLine("3 - Quartos Reservados");
                Console.WriteLine("4 - Reservas Registradas");
                Console.WriteLine("5 - Excluir Reserva");
                Console.WriteLine("6 - Sair");

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

                    case 6:
                        Environment.Exit(0);
                        break;
                }
            }
            

            Console.ReadKey();

        }
    }
}
