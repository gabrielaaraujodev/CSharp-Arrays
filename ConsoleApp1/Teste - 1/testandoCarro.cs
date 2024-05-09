using System;
using System.Globalization;

namespace Treinamento
{
    class testandoCarro
    {

        enum NivelDeDificudadeDoJogo
        {
            Baixo = 0,
            Médio = 1,
            Difícil = 2,
            SuperDifícil = 3
        }

        static void Main(string[] args)
        {
            DateTime dia = new DateTime();

            carro meuCarro = new carro();

            NivelDeDificudadeDoJogo nivel = NivelDeDificudadeDoJogo.SuperDifícil;

            int posicaoNivel = (int)nivel;
            /*Console.WriteLine(nivel);
            Console.WriteLine(posicaoNivel);*/


            var numero = 1;

            int? idade = 2;

            Console.WriteLine(idade.HasValue);

            Console.ReadLine();
        }
    }
}
