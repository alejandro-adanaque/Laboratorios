using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MayorTresNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            int A = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            int B = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese un numero");
            int C = Convert.ToInt16(Console.ReadLine());
            if (A > B && A > C)
            {
                Console.WriteLine("El mayor de ellos es " + A);
            }
            else
            {
                if (B > A && B > C)
                {
                    Console.WriteLine("El mayor de ellos es " + B);
                }
                else
                {
                    Console.WriteLine("El mayor de ellos es " + C);
                }
            }
            Console.ReadLine();

            //Sacar el promedio del mayor y el menor
            if (A > B && A > C && B > C)
            {
                Console.WriteLine("El promedio de el mayor y el menor es: " + (A + C));

            }
            else if(A > B && A > C && C > B)
            {
                Console.WriteLine("El promedio de el mayor y el menor es: " + (A + B));
            }


            else if (B > A && B > C && A>C)
                {
                    Console.WriteLine("El promedio de el mayor y el menor es: " + (B+C));
                }
            else if (B > A && B > C && C > A)
                {
                    Console.WriteLine("El promedio de el mayor y el menor es: " + (C+A));
                }
            else if (C > A && C > B && A > B)
            {
                Console.WriteLine("El promedio de el mayor y el menor es: " + (C + B));
            }
            else if (C > A && C > B && B > A)
            {
                Console.WriteLine("El promedio de el mayor y el menor es: " + (C + A));
            }

            Console.ReadLine();

            //Forma descendente
            if (A > B && A > C && B > C)
            {
                Console.WriteLine($"En forma descendente se muestra asi : {A},{B},{C}");

            }
            else if (A > B && A > C && C > B)
            {
                Console.WriteLine($"En forma descendente se muestra asi : {A},{C},{B}");
            }


            else if (B > A && B > C && A > C)
            {
                Console.WriteLine($"En forma descendente se muestra asi : {B},{A},{C}");
            }
            else if (B > A && B > C && C > A)
            {
                Console.WriteLine($"En forma descendente se muestra asi : {B},{C},{A}");
            }
            else if (C > A && C > B && A > B)
            {
                Console.WriteLine($"En forma descendente se muestra asi : {C},{A},{B}");
            }
            else if (C > A && C > B && B > A)
            {
                Console.WriteLine($"En forma descendente se muestra asi : {C},{B},{A}");
            }

            Console.ReadLine();
        }
    }
}