using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08CostoDeLlamadas
{
    class Program
    {
        static void titulo()
        {
            Console.Write("Bienvenido: a \"SENATI\"\n");
            Console.WriteLine("========================================");
        }

        static void Main(string[] args)
        {
            //Calcula el costo de una llamada

            const double PRECIO_X_MINUTO = 0.25;
            titulo();

            Console.Write("Ingrese cantidad de minutos de la llamada: ");
            int cantMinutos = int.Parse(Console.ReadLine());

            double precioAPagar = PRECIO_X_MINUTO * cantMinutos;

            Console.WriteLine($"Usted pagará por {cantMinutos} minutos un total de:  {precioAPagar.ToString("c2")}" );

            
            Console.ReadKey();
        }
    }
}
