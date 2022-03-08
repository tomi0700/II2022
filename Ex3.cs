using System;

namespace Ex3
{
    class Ex3
    {
        static void Main(string[] args)
        {
            int optiune;
            float f, c;
            Console.WriteLine("Alegeti optiunea de conversie:\n 1.Din Celsius in Fahrenheit\n 2.Din Fahrenheit in Celsius\n ");
            optiune = int.Parse(Console.ReadLine());
            switch (optiune)
            {
                case 1:
                    Console.WriteLine("Introduceti temperatura in grade Celsius:");
                    c = float.Parse(Console.ReadLine());
                    CelFahr(c);
                    break;

                case 2:
                    Console.WriteLine("Introduceti temperatura in grade Fahrenheit:");
                        f = float.Parse(Console.ReadLine());
                        FahrCel(f);
                        break;
                default:
                    Console.WriteLine("Optiune invalida");
                    break;
            }
            Console.ReadKey();

        }
       static void CelFahr(float c)
        {
            float f;
            f = c * 9 / 5 + 32;
            Console.WriteLine("Temperatura {0} transformata in grade Fahrenheit este {1}", c, f);
        }
        static void FahrCel(float f)
        {
            float c;
            c = (f - 32) * 5 / 9;
            Console.WriteLine("Temperatura {0} transformata in grade Celsius este {1}", f, c);
        }
    }
}
