using System;
namespace NumerosArabicos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elegimos las opcion de las conversiones
            Console.WriteLine("1) De Romano a Arábico");
            Console.WriteLine("2) De Arábico a Romano");
            Console.Write("Elija una opción: ");
            //Capturamos la opcion elegida
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                //En el caso de aver elegido la opcion 1
                Console.Write("Ingrese Número Romano: ");
                string romano = Console.ReadLine();
                string nRomano = romano.ToUpper();
                string respuestaA = string.Empty;
                switch (nRomano)
                {
                    case "I":
                        respuestaA = "1";
                        break;
                    case "V":
                        respuestaA = "5";
                        break;
                    case "X":
                        respuestaA = "10";
                        break;
                    case "L":
                        respuestaA = "50";
                        break;
                    case "C":
                        respuestaA = "100";
                        break;
                    case "D":
                        respuestaA = "500";
                        break;
                    case "M":
                        respuestaA = "1000";
                        break;
                    default:
                        respuestaA = "No es un numero Romano!";
                        break;

                }
                Console.WriteLine("Su número Arábico es: " + respuestaA);
            }
            //En el caso de aver elegido la opcion 2
            else if (n == 2)
            {
                Console.Write("Ingrese Número Arábico: ");
                int arabico = int.Parse(Console.ReadLine());
                string respuestB = string.Empty;
                switch (arabico)
                {
                    case 1:
                        respuestB = "I";
                        break;
                    case 5:
                        respuestB = "V";
                        break;
                    case 10:
                        respuestB = "X";
                        break;
                    case 50:
                        respuestB = "L";
                        break;
                    case 100:
                        respuestB = "C";
                        break;
                    case 500:
                        respuestB = "D";
                        break;
                    case 1000:
                        respuestB = "M";
                        break;
                    default:
                        respuestB = "No es un numero Arábico!";
                        break;

                }
                Console.WriteLine("Su Número Romano es: " + respuestB);
            }
            else
            {
                Console.WriteLine("Se ocasiono un Error!");
            }
            Console.ReadKey();
        }
    }
}

