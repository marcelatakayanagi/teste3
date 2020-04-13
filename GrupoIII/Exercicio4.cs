using System;

namespace GrupoIII
{
    public class Exercicio4
    {

        private static void ValidarInput(int a, int b, string opt)
        {
            var op = opt[0];
            if (op != '+' && op != '-' && op != '*' && op != '/' && op != '%') throw new InvalidOperationException();
            if (op == '/' && b == 0) throw new DivideByZeroException();
            if (a < 0 || a > 100 || b < 0 || b > 100) throw new ArgumentOutOfRangeException();
            if (a % 5 == 0 || b % 3 == 0) throw new ArithmeticException();
        }

        private static void ValidarInput(int a, int b, char op)
        {

            if (op != '+' || op != '-' || op != '*' || op != '/' || op != '%') throw new InvalidOperationException();
            if (b == 0) throw new DivideByZeroException();
            if (a < 0 || a > 100 || b < 0 || b > 100) throw new ArgumentOutOfRangeException();
            if (a % 5 == 0 || b % 3 == 0) throw new ArithmeticException();
        }

    
        public static void CalcularNumeros()
        {
            //a.Cria uma função que solicite dois números, a e b, e um caracter op. De acordo com ‘op’ deverão realizar o conjunto
            //de operações de soma, subtração multiplicação,divisão e resto de divisão e apresentar o seu resultado. 
            Console.WriteLine("Digite um número");
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número");
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a operação");
            var op = Console.ReadLine();

            ValidarInput(a, b, op);
            var res = 0;

            switch (op)
            {
                case "+":
                    res = a + b;
                    break;
                case "-":
                    res = a - b;
                    break;
                case "*":
                    res = a * b;
                    break;
                case "/":
                    res = a / b;
                    break;
                case "%":
                    res = a % b;
                    break;

            }
            Console.WriteLine(res);
        }

    }
}
