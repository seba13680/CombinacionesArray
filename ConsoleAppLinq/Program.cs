using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var C1 = new[] { 1, 2, 3, 4, 5, 6, 7};
            var C2 = new[] { 20, 30, 40, 50 };
            var C3 = new[] { 100, 200, 300, 400, 500, 600, 700, 800 };
            
            var menor = 0;
            
            if (C1.Length < C2.Length && C1.Length < C3.Length)
            {
                menor = C1.Length;
            }
            else
            {
                if (C2.Length < C1.Length && C2.Length < C3.Length)
                {
                    menor = C2.Length;
                }
                else
                {
                    menor = C3.Length;
                }
            }

            int[,] combinacion = new int[menor, 3];

            for (int i = 0; i < menor; i++)
            {
                var x = 0;
                combinacion[i, x] = C1[i];
                x++;
                combinacion[i, x] = C2[i];
                x++;
                combinacion[i, x] = C3[i];
            }

            int[,] C4 = new int[menor, 3];
            for (int i = 0; i < menor; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    switch (j)
                    {
                        case 0:
                            C4[i, j] = C1[i];
                            break;
                        case 1:
                            C4[i, j] = C2[i];
                            break;
                        case 2:
                            C4[i, j] = C3[i];
                            break;
                        default:
                            break;
                    }
                }

            }
            Console.WriteLine("Las combinaciones son: ");
            for (int i = 0; i < menor; i++)
            {
                for (int l = 0; l < 3; l++)
                {
                    Console.Write(C4[i, l] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.Write("C1 no combinada:[");
            for (int i = menor; i < C1.Length; i++)
            {
                Console.Write(C1[i] + " ");
            }
            Console.WriteLine("]");

            Console.WriteLine();
            Console.Write("C2 no combinada:[");
            for (int i = menor; i < C2.Length; i++)
            {
                Console.Write(C2[i] + " ");
            }
            Console.WriteLine("]");

            Console.WriteLine();
            Console.Write("C3 no combinada:[");
            for (int i = menor; i < C3.Length; i++)
            {
                Console.Write(C3[i] + " ");
            }
            Console.WriteLine("]");

            Console.ReadKey();

        }
         
    }
}
