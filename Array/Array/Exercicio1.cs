using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Exercicio1
    {
        static void Main(string[] args)
        {
            int[] vet = new int[20];
            int i, value;

            for (i = 0; i < vet.Length; i++)
            {
                Console.WriteLine($"Informe o {i + 1}º valor para o vetor: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Informe um valor para ser buscado no vetor: ");
            value = int.Parse(Console.ReadLine());

            for (i = 0;i < vet.Length; i++)
            {
                if (value == vet[i])
                {
                    Console.WriteLine("Este valor aparece na(s) posição(s): " + i);
                }
            }

            Console.ReadLine();
        }
    }
}
