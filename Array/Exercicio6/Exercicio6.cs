using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] age = new int[5];
            int i, media = 0;

            for (i = 0; i < age.Length; i++)
            {
                Console.WriteLine($"Informe a idade do {i + 1}º aluno: ");
                var temp = Console.ReadLine();

                if (temp == string.Empty)
                {
                    continue;
                }

                int.TryParse(temp, out int result);
                age[i] = result;


                if (age[i] == 0 || i > age.Length)
                {
                    break;
                }

                media += age[i];
            }

            Console.WriteLine("");

            media = media / i;

            Console.WriteLine("A média das idades é: " + media);

            Console.WriteLine("");

            Console.Write("A idade dos alunos é: ");


            foreach (int n in age)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("A(s) idade(s) superior(es) a média é(são): ");

            for (i = 0; i < age.Length; ++i)
            {
                if (age[i] > media)
                {
                    Console.Write(age[i] + " ");
                }
            }

            Console.ReadLine();          
        }
    }
}
