using System;
namespace CasoConsultorio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Capturamos el numero de consultas
            Console.WriteLine($"Consultorio del Dr.Matasano");
            Console.Write($"Numero de consultas: ");
            int consulta = int.Parse(Console.ReadLine());

            if (consulta > 8)
            {
                double pago = 1200 + (50 * (consulta - 8));
                Console.WriteLine("El pago por consulta es: 1200");
                //Dependiendo si las consultas exeden a 10 se cobra un tratamiento 
                Console.WriteLine($"El pago por tratamiento es: {50 * (consulta - 8)}");
                Console.WriteLine($"Pago total: {pago} ");
                Console.ReadKey();
            }
            else if (9 > consulta && consulta > 0)
            {
                //Consultas<10
                switch (consulta)
                {
                    case 1:
                        Console.WriteLine("El pago por las consultas es: 200");
                        break;
                    case 2:
                        Console.WriteLine("El pago por las consultas es: 400");
                        break;
                    case 3:
                        Console.WriteLine("El pago por las consultas es: 600");
                        break;
                    case 4:
                        Console.WriteLine("El pago por las consultas es: 750");
                        break;
                    case 5:
                        Console.WriteLine("El pago por las consultas es: 900");
                        break;
                    case 6:
                        Console.WriteLine("El pago por las consultas es: 1000");
                        break;
                    case 7:
                        Console.WriteLine("El pago por las consultas es: 1100");
                        break;
                    case 8:
                        Console.WriteLine("El pago por las consultas son: 1200");
                        break;


                }
            }
            else
            {
                //Por si no se registra alguna consulta
                Console.WriteLine($"No registro alguna consulta");
            }
            Console.ReadKey();
        }
    }
}

