using System;

namespace MetodaJacobi
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[,] A = new int[3, 3] { { 10, 2, -1 }, { -2, -5, 1 }, { -3, 1, -5 } };
            int[,] B = new int[3, 1] { { 9 }, { -1 }, { 8 } };
            decimal[,] Alfa = new decimal[3, 3];
            for(int i=0;i<n;i++)
            {
                for (int j = 0; j < n; j++)
                    if (i != j)
                        Alfa[i, j] = -A[i, j] / A[i, i];
                    else
                        Alfa[i, j] = 0;
            }

            AfisareMatrice(Alfa);

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }

        static void AfisareMatrice(decimal[,] M)
        {

        }

        static void AfisareMatrice(int[,] M)
        {

        }
       
    }
}
