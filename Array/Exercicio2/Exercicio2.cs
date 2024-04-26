using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Exercicio2
    {
        static void Main(string[] args)
        {
            int[] vet = new int[5];
            int i, menor = 0, posicao;


            for (i = 0; i < vet.Length; i++) 
            {

                Console.WriteLine($"Informe o {i + 1}º valor: ");
                vet[i] = int.Parse(Console.ReadLine());

            }

            for (i = 0; i < vet.Length; i++)
            {
                if (vet[i] < vet[menor])
                {
                    menor = i;
                }
            }

                 Console.WriteLine("A posição do menor elemento desse Array é: " + menor);

                posicao = vet[0];
                vet[0] = vet[menor];
                vet[menor] = posicao;

                Console.WriteLine("O elemento na posição ZERO agora vale: " + vet[0] + " e o elemento da posição do menor número agora vale: " + vet[menor]);

            foreach (int n in vet)
            {
                Console.Write(n + "  ");
            }

            Console.ReadLine();
        }
    }
}
