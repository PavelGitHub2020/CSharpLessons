using System;

namespace _3
{
    class Program
    {
        //В двумерном массиве порядка M на N поменяйте местами заданные столбцы
        static void Main(string[] args)
        {
            Array1 array = new Array1(4, 7);
            array.RandomNumber();
            array.PrintArray();
            array.ChangeCols();
            array.PrintArray();
        }

        class Array1
        {
            private static int rows, cols;
            private int[,] array = new int[rows, cols];

            public Array1(int ROWS, int COLS)
            {
                rows = ROWS;
                cols = COLS;
                array = new int[ROWS, COLS];
            }

            public void RandomNumber()
            {
                Random random = new Random();

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = random.Next(0, 100);
                    }
                }
            }

            public void PrintArray()
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            public void ChangeCols()
            {
                int tmp;

                for (int i = 0; i < array.GetLength(0); i++)
                {
                    tmp = array[i, 0];

                    array[i, 0] = array[i, array.GetLength(1) - 1];

                    array[i, array.GetLength(1) - 1] = tmp;
                }
            }


        }
    }
}
