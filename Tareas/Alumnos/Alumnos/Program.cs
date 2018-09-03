using System;

namespace Alumnos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Capturar Alumno1 y sus notas 
            Console.Write("Ingrese Alumno: ");
            string alumno1 = Console.ReadLine();
            Console.WriteLine("Ingrese sus notas: ");
            int notaA1 = int.Parse(Console.ReadLine());
            int notaA2 = int.Parse(Console.ReadLine());
            int notaA3 = int.Parse(Console.ReadLine());

           //Capturar Alumno2 y sus notas
            Console.Write("Ingrese Alumno: ");
            string alumno2 = Console.ReadLine();
            Console.WriteLine("Ingrese sus notas: ");
            int notaB1 = int.Parse(Console.ReadLine());
            int notaB2 = int.Parse(Console.ReadLine());
            int notaB3 = int.Parse(Console.ReadLine());

            //Capturar Alumno3 y sus notas
            Console.Write("Ingrese Alumno: ");
            string alumno3 = Console.ReadLine();
            Console.WriteLine("Ingrese sus notas: ");
            int notaC1 = int.Parse(Console.ReadLine());
            int notaC2 = int.Parse(Console.ReadLine());
            int notaC3 = int.Parse(Console.ReadLine());

            //Sacar promedios por cada alumno
            double promedioAlumno1 = (notaA1 + notaA2 + notaA3) / 3;
            double promedioAlumno2 = (notaB1 + notaB2 + notaB3) / 3;
            double promedioAlumno3 = (notaC1 + notaC2 + notaC3) / 3;

            string[] alumno = new string[3] { alumno1, alumno2, alumno3 };
            double[] promedios = new Double[3] { promedioAlumno1, promedioAlumno2, promedioAlumno3 };
            Console.Clear();
            Console.WriteLine("Escoja un alumno para ver sus notas:");
            Console.WriteLine("1) " + alumno1);
            Console.WriteLine("2) " + alumno2);
            Console.WriteLine("3) " + alumno3);
            Console.WriteLine("N°:");
            int respuesta = int.Parse(Console.ReadLine());


            if (respuesta== 1)
            {
                Console.WriteLine($"El Alumno {alumno[0]} tiene de promedio : {promedios[0]}");
                if (promedioAlumno1 <= 10)
                {
                    Console.WriteLine($"Alumno desaprovado");
                }
                else if (promedioAlumno1 > 10 && promedioAlumno1 <= 13)
                {
                    Console.WriteLine($"Alumno a medias");
                }
                else
                {
                    Console.WriteLine($"Alumno excelente");
                }
            }
            else if (respuesta == 2)
            {
                Console.WriteLine($"El Alumno {alumno[1]} tiene de promedio : {promedios[1]}");
                if (promedioAlumno2 <= 10)
                {
                    Console.WriteLine($"Alumno desaprobado");
                }
                else if (promedioAlumno2 > 10 && promedioAlumno2 <= 13)
                {
                    Console.WriteLine($"Alumno a medias");
                }
                else
                {
                    Console.WriteLine($"Alumno excelente");
                }
            }
            else
            {
                Console.WriteLine($"El Alumno {alumno[2]} tiene de promedio : {promedios[2]}");
                if (promedioAlumno3 <= 10)
                {
                    Console.WriteLine($"Alumno desaprobado");
                }
                else if (promedioAlumno3 > 10 && promedioAlumno3 <= 13)
                {
                    Console.WriteLine($"Alumno a medias");
                }
                else
                {
                    Console.WriteLine($"Alumno excelente");
                }
            }
            Console.ReadKey();
        }
    }
}

