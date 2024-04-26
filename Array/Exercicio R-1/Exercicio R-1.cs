using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_R_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamanhoArray = 100;
            double[] vet = new double[tamanhoArray];
            int cont = 0, cont2 = 0;

            while (cont < tamanhoArray ) 
            {
                if (cont2 % 7 != 0 || cont2 % 10 == 7)
                {
                    vet[cont] = cont2;
                    cont++;
                }

                cont2++;
            }

            foreach (int n in vet) 
            {
                Console.Write(n + " ");   
            }
            

            Console.ReadLine();
        }
    }
}
