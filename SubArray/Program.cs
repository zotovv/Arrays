using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubArray
{
    class Program
    {
        static int[] SubArray(int[] array, int index, int count)
        {
            int[] array1 = new int[count];
            int k = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                if (array.Length > index)
                {
                    array1[k] = array[index];
                }
                else
                {
                    array1[k] = 1;
                }

                index++;
                k++;
            }

            return array1;
        }

        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i * 2;
            }


            Console.WriteLine("Введите индекс массива: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество элементов: "); 
            int count = Convert.ToInt32(Console.ReadLine());

            array = SubArray(array, index, count);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
          

            // Delay
            Console.ReadKey();
        }
    }
}
