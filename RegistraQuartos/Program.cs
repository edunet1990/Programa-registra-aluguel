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
            Registro R = new Registro();
            Console.Write("Quantos aluguéis serão registrados? ");
            R.N = int.Parse(Console.ReadLine());


            R.Registra(R.N);
            R.MostraRegistros(R.N);

            Console.ReadKey();

        }
    }
}
