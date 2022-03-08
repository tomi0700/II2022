using System;

namespace Ex1
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int n, f0 = 0, f1 = 1, fibo = 0;
            Console.WriteLine("Introduceti valoarea lui n");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Secventa Fibonnaci este : ");
                Console.Write("{0} {1} ", f0, f1);
                for (int i = 3; i <= n; i++)
                {
                    fibo = f0 + f1;
                    Console.Write("{0} ", fibo);
                    f0 = f1;
                    f1 = fibo;

                }

            }
        }


    }

