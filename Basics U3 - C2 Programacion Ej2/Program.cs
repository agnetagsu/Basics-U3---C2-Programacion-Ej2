using System;

namespace Basics_U3___C2_Programacion_Ej2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 99;
            double A = 5.9;
            char C = 'a';
            int valorASCII = 'a';

            Console.WriteLine("Variable N = "+N+"\n");
            Console.WriteLine("Variable A = "+A+"\n");
            Console.WriteLine("Variable C = "+C+"\n");
            Console.WriteLine("{0}+{1}={2}\n", N,A,N+A);
            Console.WriteLine("{0}-{1}={2}\n", A, N, A-N);
            Console.WriteLine("Valor numérico del carácter {0} = {1}\n", C, valorASCII);
        }
    }
}
