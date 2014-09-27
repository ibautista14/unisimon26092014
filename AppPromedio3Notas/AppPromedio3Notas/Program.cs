using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            float nota1, nota2, nota3, promedio;
            Console.WriteLine("Programa promedio 3 notas");
            Console.WriteLine("Digite nota 1:");
            nota1=float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 2:");
            nota2=float.Parse(Console.ReadLine());
            Console.WriteLine("Digite nota 3:");
            nota3=float.Parse(Console.ReadLine());
            promedio = (nota1 + nota2 + nota3)/3;
            if (promedio >= 3.5)
            {
                Console.WriteLine("Es promocionado del diplomado");
            }
            else
            {
                 Console.WriteLine("Es promocionado del diplomado");
            }
            Console.ReadKey();
            

        }
        }
}