using System;

namespace Ex4
{
    class Ex4
    {
        static void Main(string[] args)
        {
            float inaltime, greutate_ideala;
            int varsta, optiune;
            Console.WriteLine("Va rugam introduceti inaltimea dumneavoastra in cm : ");
            inaltime = float.Parse(Console.ReadLine());
            Console.WriteLine("Va rugam introduceti varsta dumneavostra in ani : ");
            varsta = int.Parse(Console.ReadLine());
            Console.WriteLine("Va rugam introduceti sexul dumneavoastra:\n 1.Feminin\n 2.Masculin");
            optiune = int.Parse(Console.ReadLine());
            switch (optiune)
            {
                case 1:
                    greutate_ideala=Calculf(inaltime, varsta);
                    AfisareGreutate(greutate_ideala);
                    break;
                case 2:
                    greutate_ideala=Calculb(inaltime, varsta);
                    AfisareGreutate(greutate_ideala);
                    break;
                default:
                    Console.WriteLine("Optiunea nu este valida");
                    break;

            }
            Console.ReadKey();
        }
        static float Calculf(float inaltime,int varsta)
        {
            return (float)(inaltime-100-((inaltime-150)/2.5))+((varsta-20)/6);
        }
        static float Calculb(float inaltime, int varsta)
        {
            return (float)(inaltime - 100 - ((inaltime - 150) / 4)) + ((varsta - 20) / 4);

        }
        static void AfisareGreutate(float greutate_ideala)
        {
            Console.WriteLine("Greutatea ideala calculata utilizand valorile introduse de dumneavoastra este: {0} ", greutate_ideala);
        }
    }
}
