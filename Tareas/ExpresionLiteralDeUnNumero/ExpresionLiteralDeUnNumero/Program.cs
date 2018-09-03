using System;

namespace ExpresionLiteralDeUnNumero
{
    class Program
    {
        //Declaramos la variable/Digito en primer lugar
        static void primerDigito(string n)
        {
            string num1 = string.Empty;
            switch (n)
            {
                case "1":
                    num1 = "Ciento";
                    break;
                case "2":
                    num1 = "Docientos";
                    break;
                case "3":
                    num1 = "Trecientos";
                    break;
                case "4":
                    num1 = "Cuatrocientos";
                    break;
                case "5":
                    num1 = "Quinientos";
                    break;
                case "6":
                    num1 = "Seiscientos";
                    break;
                case "7":
                    num1 = "Setecientos";
                    break;
                case "8":
                    num1 = "Ochocientos";
                    break;
                case "9":
                    num1 = "Novecientos";
                    break;
            }
            Console.Write(" " + num1);
        }
        //Declaramos la variable/Digito en segundo Lugar
        static void segundoDigito(string n)
        {
            string num1 = string.Empty;
            switch (n)
            {
                case "1":
                    num1 = "dieci";
                    break;
                case "2":
                    num1 = "veinti";
                    break;
                case "3":
                    num1 = "treinta y";
                    break;
                case "4":
                    num1 = "cuarenta y";
                    break;

                case "5":
                    num1 = "cincuenta y";
                    break;
                case "6":
                    num1 = "sesenta y";
                    break;
                case "7":
                    num1 = "setenta y";
                    break;
                case "8":
                    num1 = "ochenta y";
                    break;
                case "9":
                    num1 = "noventa y";
                    break;
            }
            Console.Write(" " + num1);
        }
        //Declaramos la variable/Digito en tercer lugar
        static void tercerDigito(string n)
        {
            string num1 = string.Empty;
            switch (n)
            {
                case "1":
                    num1 = "uno";
                    break;
                case "2":
                    num1 = "dos";
                    break;
                case "3":
                    num1 = "tres";
                    break;
                case "4":
                    num1 = "cuatro";
                    break;

                case "5":
                    num1 = "cinco";
                    break;
                case "6":
                    num1 = "seis";
                    break;
                case "7":
                    num1 = "siete";
                    break;
                case "8":
                    num1 = "ocho";
                    break;
                case "9":
                    num1 = "nueve";
                    break;
            }
            Console.Write(" " + num1);
        }
        static void Main(string[] args)
        { 
            //Capturamos los 3 digitos
            Console.Write("Ingrese un Número de tres digitos: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero >= 100)
            {
                string cadena = numero.ToString();
                string n1 = cadena.Substring(0, 1);
                string n2 = cadena.Substring(1, 1);
                string n3 = cadena.Substring(2, 1);
                primerDigito(n1);
                segundoDigito(n2);
                tercerDigito(n3);
            }
            else
            {
                //Impresion por si no se ingresa un numero de 3 digitos 
                Console.WriteLine("No ingreso un numero de tres digitos!");
            }


            Console.ReadLine();
        }
    }
}

