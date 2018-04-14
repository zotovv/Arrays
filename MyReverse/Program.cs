using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyReverse
{
    class Program
    {
        static int[] MyReverse(int[] array)
        {
            
            int buf = 0;
            int n = array.Length;
            int j = n - 1;

            for (int k = 0; k < j; k++)
            {
                buf = array[k];
                array[k] = array[j];
                array[j] = buf;
                j--;
            }

            return array;           
        }
           
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }

            array = MyReverse(array);

            for (int i = 0; i < array.Length; i++)

            {
                Console.WriteLine(array[i]);
            }

            // Delay
            Console.ReadKey();
        }
    }
}
