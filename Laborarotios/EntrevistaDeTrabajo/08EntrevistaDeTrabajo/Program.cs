using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08EntrevistaDeTrabajo
{
    class Program
    {
        static int calculaEdad(int anioNacimiento)
        {
            DateTime fechaActual = DateTime.Now; //Obtiene la fecha de la computadora
            int anioActual = fechaActual.Year; //Obtiene el año actual
            int mesActual = fechaActual.Month; //Obtiene el mes
            int diaActual = fechaActual.Day;   //Obtiene el dia

            int edadActual = anioActual - anioNacimiento; //Obtiene edad
            return edadActual;
        }

        static void titulo()
        {
            Console.WriteLine("Bienvenido a \"SENATI\"\n");
            Console.WriteLine("================================================");
        }

        static void Main(string[] args)
        {
            //Programa que calcula las edades de personas en una entrevista

            titulo();

            Console.Write("Ingrese su Nombre: ");
            String nombre = Console.ReadLine();

            Console.Write("Ingrese año de naciemiento: ");
            int anioNacimiento = int.Parse(Console.ReadLine());

            int edad = calculaEdad(anioNacimiento);

            Console.WriteLine($"Bienvenido {nombre} usted tiene {edad} para la entrevista");


            Console.ReadKey();
        }
    }
}
