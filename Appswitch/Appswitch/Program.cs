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
            num = numero.ToUpper();
            switch (num)
             {
                case "UNO":
                    Console.WriteLine("1");
                    break;

                case "DOS":
                    Console.WriteLine("2");
                    break;

               case "TRES":
                    Console.WriteLine("3");
                    break;

                case "CUATRO":
                    Console.WriteLine("4");
                    break;

                case "CINCO":
                    Console.WriteLine("5");
                    break;

                default:
                    Console.WriteLine("NUMERO FUERA DEL RANGO");
                    break;
        }
            Console.ReadKey();
    }
}
}