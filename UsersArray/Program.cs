using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число элементов массива: ");
            int[]array  = new int[Convert.ToInt32(Console.ReadLine())];

            int maxValue = 0, minValue = 0, sum = 0;

            // Заполнение массива
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }

            maxValue = array[0];
            minValue = array[0];

            // Вывод на консоль нечётных, максимального, минимального,
            // среднего арифметического и суммы значений массива.
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] % 2) != 0)
                {
                    Console.WriteLine("Нечётное значение массива: {0}", array[i]);
                }

                if (maxValue < array[i])
                {
                    maxValue = array[i];
                }

                if (minValue > array[i])
                {
                    minValue = array[i];
                }
             
                sum += array[i];
            }

            Console.WriteLine("Максимальное значение массива: {0}", maxValue);
            Console.WriteLine("Минимальное значение массива: {0}", minValue);
            Console.WriteLine("Сумма значений элементов массива: {0}", sum);
            Console.WriteLine("Среднее арифметическое значений элементов массива: {0}", sum / array.Length);

            // Delay
            Console.ReadKey();
        }
    }
}
