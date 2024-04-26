using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Exercicio4
    {
        static void Main(string[] args)
        {
            double[] vet = new double[5];

            for (int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine($"Informe o {i + 1}º valor: ");
                vet[i] = double.Parse(Console.ReadLine());   
            }

            Console.WriteLine(" ");

            double[] vet2 = new double[vet.Length];

            for (int i = 0;i < vet2.Length; i++)
            {
                vet2[i] = vet[i] * 2; 
            }

            foreach (int n in vet)
            {
                Console.WriteLine(n + " ");
            }

            Console.WriteLine(" ");

            foreach (int x in vet2)
            {
                Console.WriteLine(x + " ");
            }

            Console.ReadLine();
        }
    }
}
