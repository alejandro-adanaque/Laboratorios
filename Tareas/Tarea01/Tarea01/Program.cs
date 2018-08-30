using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumA, NumB, tem;
            Console.WriteLine("Ingresa el valor de NumA ");
            NumA = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el valor de NumB ");
            NumB = Convert.ToInt32(Console.ReadLine());
            tem = NumA;
            NumA = NumB;
            NumB = tem;
            Console.WriteLine("Resultado:");
            Console.Write("Ahora el valor de NumA es: " + NumA + " y el valor de NumB es: " + NumB);
            Console.ReadLine();
        }
    }
}