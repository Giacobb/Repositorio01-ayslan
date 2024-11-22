using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediaponderada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite a nota da sua primeira prova: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite a nota da sua segunda prova: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite a nota do seu primeiro trabalho: ");
            double trab1 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite a nota do seu segundo trabalho: ");
            double trab2 = double.Parse(Console.ReadLine());

            double media = (((nota1 * 3) + (nota2 * 4) + (trab1 * 1) + (trab2 * 2)) / 10);

            Console.Write("\n");
            Console.Write("\n");
            Console.Write("\n");
            Console.Write("====================================================");

            Console.WriteLine($"\nSua média é: {media:F1}");


            Console.ReadKey();









            
        }
    }
}
