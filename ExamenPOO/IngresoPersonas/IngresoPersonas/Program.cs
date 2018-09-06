using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresoPersonas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Capturar Peronas 
            Console.Write("Ingrese nombre: ");
            string nombre1 = Console.ReadLine();
            Console.Write("Ingrese apellido paterno: ");
            string paterno1 = Console.ReadLine();
            string cpaterno1 = paterno1[0].ToString();
            Console.Write("Ingrese apellido materno: ");
            string materno1 = Console.ReadLine();
            string cmaterno1 = materno1[0].ToString();
            Console.Clear();

            Console.Write("Ingrese nombre: ");
            string nombre2 = Console.ReadLine();
            Console.Write("Ingrese apellido paterno: ");
            string paterno2 = Console.ReadLine();
            string cpaterno2 = paterno2[0].ToString();
            Console.Write("Ingrese apellido materno: ");
            string materno2 = Console.ReadLine();
            string cmaterno2 = materno2[0].ToString();
            Console.Clear();

            Console.Write("Ingrese nombre: ");
            string nombre3 = Console.ReadLine();
            Console.Write("Ingrese apellido paterno: ");
            string paterno3 = Console.ReadLine();
            string cpaterno3 = paterno3[0].ToString();
            Console.Write("Ingrese apellido materno: ");
            string materno3 = Console.ReadLine();
            string cmaterno3 = materno3[0].ToString();
            Console.Clear();

            Console.Write("Ingrese nombre: ");
            string nombre4 = Console.ReadLine();
            Console.Write("Ingrese apellido paterno: ");
            string paterno4 = Console.ReadLine();
            string cpaterno4 = paterno4[0].ToString();
            Console.Write("Ingrese apellido materno: ");
            string materno4 = Console.ReadLine();
            string cmaterno4 = materno4[0].ToString();
            Console.Clear(); 

            Console.Write("Ingrese nombre: ");
            string nombre5 = Console.ReadLine();
            Console.Write("Ingrese apellido paterno: ");
            string paterno5 = Console.ReadLine();
            string cpaterno5 = paterno5[0].ToString();
            Console.Write("Ingrese apellido materno: ");
            string materno5 = Console.ReadLine();
            string cmaterno5 = materno5[0].ToString();
            Console.Clear();

            DateTime fechaActual = DateTime.Now; //Obtiene la fecha de la computadora
            int anioActual = fechaActual.Year; //Obtiene el año actual
            int mesActual = fechaActual.Month; //Obtiene el Mes actual
            int diaActual = fechaActual.Day; //Obtiene el dia actual

            Console.WriteLine($"De {nombre1} {paterno1} {materno1} ");
            Console.WriteLine($"Su CODIGO es: {anioActual}-{cpaterno1}-{cmaterno1}-{mesActual}-{diaActual}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"De {nombre2} {paterno2} {materno2} ");
            Console.WriteLine($"Su CODIGO es: {anioActual}-{cpaterno2}-{cmaterno2}-{mesActual}-{diaActual}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"De {nombre3} {paterno3} {materno3} ");
            Console.WriteLine($"Su CODIGO es: {anioActual}-{cpaterno3}-{cmaterno3}-{mesActual}-{diaActual}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"De {nombre4} {paterno4} {materno4} ");
            Console.WriteLine($"Su CODIGO es: {anioActual}-{cpaterno4}-{cmaterno4}-{mesActual}-{diaActual}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"De {nombre5} {paterno5} {materno5} ");
            Console.WriteLine($"Su CODIGO es: {anioActual}-{cpaterno5}-{cmaterno5}-{mesActual}-{diaActual}");

            
            Console.ReadKey();
        }
    }
}
