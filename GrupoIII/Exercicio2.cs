using System;

namespace GrupoIII
{
    public class Exercicio2
    {
        #region OlaPessoa
        public static void OlaPessoa()
        {
            //a.	Cria uma função que solicite o nome do utilizador, e apresente “Olá” seguido do nome 
            Console.WriteLine("Qual o seu nome?");
            var nome = Console.ReadLine();

            Console.WriteLine($"Olá {nome}");

        }
        #endregion

        #region QuantasPatas
        public static int QuantasPatas(int vacas, int porcos, int galinhas)
        {
            //b.Na função “QuantasPatas”, implementa o algoritmo necessário para devolver o número de patas de 
            //um conjunto de vacas, porcos e galinhas.
            var res = 0;
            res = vacas * 4;
            res = porcos * 4;
            res = galinhas * 2;

            return res;
        }
        #endregion

        #region Region
        //c.	Cria uma região de código [2 ponto]
        #endregion

        #region ParOuImpar
        //d.	Cria uma função que verifique se um número introduzido é par ou ímpar.
        //Se criaste uma região, coloca a função dentro da região 
        public static void ParOuImpar()
        {
            Console.WriteLine("Qual número?");
            var num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O número é par");
            }
            else
            {
                Console.WriteLine("O número é ímpar");
            }
        }
        #endregion

        #region Somar
        //e.	Cria uma função que calcule a soma de dois valores inteiros. Caso estes sejam iguais, 
        //calcula o triplo da soma.
        public static void Somar()
        {
            Console.WriteLine("Introduza o primeiro número");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza o segundo número");
            var num2 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine($"{(num1 + num2) * 3}");
            }
            else
            {
                Console.WriteLine($"{num1 + num2}");
            }
        }
        #endregion

        #region Potencia
        //f.	Cria uma função que apresente a potência de um número. Deverá requisitar o número e a potência. 
        public static void Potencia()
        {
            Console.WriteLine("Digite o número");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite potencia");
            int y = int.Parse(Console.ReadLine());
            int aux = 1;

            for (int i = 1; i <= y; i++)
            {
                aux *= x;
            }
            Console.WriteLine($"A potência de {x} elevado a {y} é igual a {aux}");

        }
        #endregion
    }
}
