using System;

namespace Ex2
{
    class Ex2
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            Console.WriteLine("Introduceti valoarea lui a");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti valoarea lui b");
            b = float.Parse(Console.ReadLine());
            Suma(a, b);
            Diferenta(a, b);
            Produs(a, b);
            Impartire(a, b);
            Impartire_inv(a, b);
            Console.ReadKey();

        }

        static void Suma(float a,float b)
        {
            float s = a + b;
            Console.WriteLine("Suma dintre {0} si {1} este {2}", a, b, s);
        }
        static void Diferenta(float a,float b)
        {
            float d = a - b;
            Console.WriteLine("Diferenta dintre {0} si {1} este {2}", a, b, d);
        }

        static void Produs(float a,float b)
        {
            float p = a * b;
            Console.WriteLine("Produsul dintre {0} si {1} este {2}", a, b, p);
        }
        static void Impartire(float a,float b)
        {
            float rez = a / b;
            float rest = a % b;
            Console.WriteLine("Impartirea dintre {0} si {1} returneaza rezultatul {2} si restul {3}", a, b, rez,rest);
        }
        static void Impartire_inv(float a,float b)
        {
            float rez_inv = b / a;
            float rest_inv = b % a;
            Console.WriteLine("Impartirea dintre {0} si {1} returneaza rezultatul {2} si restul {3}", b, a, rez_inv,rest_inv);
        }

    }
}
