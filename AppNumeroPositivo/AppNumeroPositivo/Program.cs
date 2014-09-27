using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumeroPositivo
{
    class Program
    {
        static void Main(string[] args)
        {
            string numero;
            int num;
            Console.WriteLine("Programa Numero Positivo");
            Console.WriteLine("Digite un numero entre 1 y 99");
            numero = Console.ReadLine();
            num = int.Parse(numero);
            if (numero.Length <= 2 && num > 0)
            {
                Console.WriteLine("El Numero es Positivo");
                if (numero.Length == 2)
                {
                    Console.WriteLine("El Numero tiene dos digitos");
                }
                else
                {
                    Console.WriteLine("El Numero tiene un digito");
                }
            }
            else
            {
                Console.WriteLine(" Numero fuera de rango");
            }
            Console.ReadKey();
        }
    }
}
