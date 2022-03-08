using System;

namespace Ex5
{
    class Ex5
    {
        static void Main(string[] args)
        {
            int n;
            float ma, mg;
            int[] sir;
            Console.WriteLine("Introduceti numarul de caractere ");
            n = int.Parse(Console.ReadLine());
            sir = new int[n];
            for (int i = 0; i < n; i++)
            {
                sir[i] = Convert.ToInt32(Console.ReadLine());
            }
            ma = MediaAritmetica(sir);
            Console.WriteLine("Media aritmetica a valorilor din sir este: {0}", ma);
            mg = MediaGeometrica(sir);
            Console.WriteLine("Media geometrica a valorilor din sire este: {0}", mg);
            Console.ReadKey();
        }
        static float MediaAritmetica(int[] sir)
        {
            double suma = 0;
            for(int i = 0; i < sir.Length; i++)
            {
                suma = suma + sir[i];
            }
            return (float)suma / sir.Length;
        }
        static float MediaGeometrica(int[] sir)
        {
            float produs = 1;
            for(int i = 0; i < sir.Length; i++)
            {
                produs = produs * sir[i];
            }
            return (float)(Math.Pow(produs, (float)1 / sir.Length));

        }
    }

}
