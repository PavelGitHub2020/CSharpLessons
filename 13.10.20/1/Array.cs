using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class Array
    {
        //Сжать массив, удалив из него все 0, заполнить освободившиеся
        //справа элементы значениями -1.
        
            public int[] array;

            public Array()
            {
                Console.WriteLine("What size array do you want?");

                int sizeArray = Convert.ToInt32(Console.ReadLine());

                array = new int[sizeArray];
            }
            public void InputArray()
            {
                Console.WriteLine("Enter array values! ");

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            public void PrintArray()
            {
                Console.WriteLine();

                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write(" ");

                    Console.Write(array[i]);
                }
            }

            public void ChangeValue()
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0)
                    {
                        array[i] = -1;
                    }
                }
            }

            public int[] ArraySort()
            {
                void Swap(ref int a, ref int b)
                {
                    int t = a;
                    a = b;
                    b = t;
                }

                for (int i = 0; i < array.Length; i++)
                {
                    int key = array[i];
                    int j = i;

                    while ((j > 1) && (array[j - 1] > key))
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        --j;
                    }

                    array[j] = key;
                }

                return array;
            }
    }
}
