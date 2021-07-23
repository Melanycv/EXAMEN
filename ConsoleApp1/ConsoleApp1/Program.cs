using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1 = 0;
            int val2 = 0;
            int total = 0;
            char op = 's';

            while (op == 's')
            {

                Console.Write("Ingresar la cantidad de vasos de agua que ha ingerido en el transcurso del día: ");
                val1 = int.Parse(Console.ReadLine());
                

                Console.Write("Mostrar la cantidad de vasos de agua ingeridos:  ");
                val2 = int.Parse(Console.ReadLine());
                int total1 = (8 - val1);

                Console.WriteLine("Vasos faltantes: " + total1);

                Console.WriteLine("Procdera a  realizar otro? ['s/n'] ");
                op = char.Parse(Console.ReadLine());
                Console.Clear();
            }
            Console.WriteLine("Fin");
            Console.ReadKey();

        }
    }
}