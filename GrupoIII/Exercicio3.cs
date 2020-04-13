using System;

namespace GrupoIII
{
    public class Exercicio3
    {
        #region Tabela
        //a.	Cria uma função que solicite ao utilizador dois números inteiros (m e n) e um caracter,
        //e que apresente uma tabela mxn preenchida com o caracter. 
        public static void CriarTabela()
        {
            Console.WriteLine("Introduza colunas");
            var m = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza linhas");
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(m);
                }
                Console.Write("\n");
            }
        }
        #endregion

        #region Multiplos
        //b.	Cria uma função que verifica se um número é múltiplo de 3 e/ou 7.
        public static void TestarMultiplo()
        {
            Console.WriteLine("Introduza um número");
            var num = int.Parse(Console.ReadLine());

            if (num % 3 == 0 && num % 7 == 0)
            {
                Console.WriteLine($"O número {num} é múltiplo de 3 e de 7");
            }
            else if (num % 3 == 0)
            {
                Console.WriteLine($"O número {num} é múltiplo de 3");
            }
            else if (num % 7 == 0)
            {
                Console.WriteLine($"O número {num} é múltiplo de 7");
            }
            else
            {
                Console.WriteLine($"O número {num} não é múltiplo de 3 nem de 7");
            }

        }
        #endregion

        #region Fatorial
        //c.	Cria uma função que apresente o fatorial de um número.
        public static void ApresentarFatorial()
        {
            Console.WriteLine("Quantos números?");
            var n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }
        private static int Fibonacci(int count)
        {
            if (count <= 1)
            {
                return 1;
            }
            var current = 1;
            var previous = 1;
            for (var i = 2; i < count; ++i)
            {
                int temp = current;
                current += previous;
                previous = temp;
            }
            return current;
        }
        #endregion
    }
}
