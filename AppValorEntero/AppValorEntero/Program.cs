using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appswitch
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ingresar un numero entre uno y cinco en castellano.
             * luego mostrar en formato numerico.si nse ingresa
             * indicando tal situacion*/
            string numero, num;

            Console.WriteLine("Programa que pasa de caracter a numero");
            Console.WriteLine("Escriba numero 1 a 5 en letras:");
            numero = Console.ReadLine();
            num = numero.ToLower();
            switch (num)
            {
                case "1":
                    Console.WriteLine("UNO");
                    break;

                case "2":
                    Console.WriteLine("DOS");
                    break;

                case "3":
                    Console.WriteLine("TRES");
                    break;

                case "4":
                    Console.WriteLine("CUATRO");
                    break;

                case "5":
                    Console.WriteLine("CINCO");
                    break;

                default:
                    Console.WriteLine("NUMERO FUERA DEL RANGO");
                    break;
            }
            Console.ReadKey();
        }
    }
}