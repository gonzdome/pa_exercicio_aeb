using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_Exercicio_AeB
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.WriteLine("Escreva o primeiro valor: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo valor: ");
            b = double.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;
           

            Console.WriteLine("O valor de A é: " + a + ",e o valor de B é: " + b + "!");

            Console.ReadKey();

        }
    }
}
