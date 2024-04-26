using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_R_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoVetor = 10;
            int[] vetA = new int[tamanhoVetor];
            int[] vetB = new int[tamanhoVetor];
            int[] vetC = new int[tamanhoVetor/2];

            for (int i = 0; i < vetA.Length; i++)
            {
                Console.WriteLine($"Informe o {i+1}º do vetor A: ");
                vetA[i] = int.Parse(Console.ReadLine());

                Console.WriteLine($"Informe o {i + 1}º do vetor B: ");
                vetB[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();

                if (vetA[i] == vetB[i])
                {
                    while (vetA[i] == vetB[i])
                    {
                        Console.WriteLine("Entre com um novo valor: ");
                        vetA[i] = int.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine();

            foreach (int n in vetA)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine();

            foreach(int x in vetB)
            {
                Console.Write(x + " ");
            }

            Console.WriteLine();

            for (int i = 0;i < vetC.Length;i++)
            {
                vetC[i] = vetA[i] - vetB[i]; 
            }

            Console.WriteLine();

            foreach (int z in vetC)
            {
                Console.Write(z + " ");
            }

           Console.ReadLine();
        }
    }
}
