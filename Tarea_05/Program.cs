using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================================");

            Console.WriteLine("  Elija una figura para calcular area");

            Console.WriteLine("=======================================");

            Console.WriteLine("1. Circulo / 2. Cuadrado / 3. Triangulo");

            Console.WriteLine("=======================================");

            int figura = Convert.ToInt32(Console.ReadLine());

            string tipo_figura;

            double resultado, 
            const double PI = 3.1416;

            switch (figura)
            {
                case 1:
                    tipo_figura = "Circulo";
                    int area_cir = 3;

                    break;
                case 2:
                    tipo_figura = "Cuadrado";
                    int area_cua = 4;
                    break;
                case 3:
                    tipo_figura = "Triangulo";
                    int area_cua = 5;
                    break;

                default:
                    tipo_figura = "error";
                    break;
            }

            Console.WriteLine(tipo_figura);

            Console.ReadKey();

        }
    }
}
