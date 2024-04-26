using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Exercicio3
    {
        static void Main(string[] args)
        {
            int[] vetA = new int[10];
            int[] vetB = new int[10];

            int[] vetC = new int[10];

            for (int i= 0; i < vetA.Length; i++)
            {
                Console.WriteLine($"Informe o {i + 1}º valor para o vetor A: ");
                vetA[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < vetA.Length; i++)
            {
                Console.WriteLine($"Informe o {i + 1}º valor para o vetor B: ");
                vetB[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < vetC.Length; i++)
            {
                vetC[i] = vetA[i] - vetB[i];
            }

            foreach (int n in vetC) 
            {
                Console.WriteLine(n);
            }


            Console.ReadLine();

        }
    }
}
