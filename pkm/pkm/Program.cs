using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pkm
{
    class Program
    {
        static string Ruta_de_Archivo = "D:/pkm/pkm/Archivos/";
        static void Main(string[] args)
        {
            Console.WriteLine("Se creara un archivo en un directorio.");
            Console.Write("Ingrese nombre de archivo: ");
            string nombreArchivo = Console.ReadLine();

            TextWriter miArchivo = new StreamWriter(Ruta_de_Archivo+nombreArchivo+".txt");

            Console.WriteLine("Ingrese el contenido del archivo");
            string mensaje = Console.ReadLine();

            miArchivo.WriteLine(mensaje);

            miArchivo.Close();

            Console.ReadKey();

        }
    }
}
