using System;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //     1  2  3  4
            //     12 13 14 5
            //     11 16 15 6
            //     10 9  8  7.

            // получаем спиральную матрицу (змейка)
            int[,] array = GetMatrix(4);

            // выводим на консоль
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("\t{0}", array[i, j]);
                }
                Console.WriteLine();
            }

        }

        //метод получения спиральной матрицы 
        public static int[,] GetMatrix(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Less or equal zero");
            }

            int[,] snakeMartix = new int[size, size];

            int digit = 1;

            int i = 0;
            int j;
            int k = 0;

            while (i < size * size)
            {
                for (j = k; j < size - k; j++)
                {
                    i++;
                    snakeMartix[k, j] = digit;
                    digit++;
                }

                for (j = k + 1; j < size - k; j++)
                {
                    i++;
                    snakeMartix[j, size - k - 1] = digit;
                    digit++;
                }

                for (j = size - k - 2; j >= k; j--)
                {
                    i++;
                    snakeMartix[size - k - 1, j] = digit;
                    digit++;
                }

                for (j = size - k - 2; j > k; j--)
                {
                    i++;
                    snakeMartix[j, k] = digit;
                    digit++;
                }

                k++;
            }

            return snakeMartix;
        }
    }
}
