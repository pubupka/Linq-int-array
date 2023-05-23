using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq__массив_интов_и_запросы_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 0, 1, 2, 3, 4, 5, 6, -7, -8, -9 };

            var positive_numbers = from number in array
                           where number > 0
                           select number;

            var not_zero = from number in array
                           where number != 0
                           select number;

            var is_even = from number in array
                          where number % 2 == 0
                          select number;

            int sum = 0;
            int mult = 1;
            int count = 0;

            foreach (int number in positive_numbers)
            {
                sum += number;
            }
            Console.WriteLine($"Сумма положительных: {sum}");

            foreach (int number in not_zero)
            {
                mult *= number;
            }
            Console.WriteLine($"Произведение ненулевых: {mult}");

            foreach (int number in is_even)
            {
                count += 1;
            }
            Console.WriteLine($"Кол-во чётных: {count}");
            sum = 0;
            mult = 1;
            count = 0;


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                    array[i] = 0;
            }
            Console.WriteLine();


            foreach (int number in positive_numbers)
            {
                sum += number;
            }
            Console.WriteLine($"Сумма положительных: {sum}");

            foreach (int number in not_zero)
            {
                mult *= number;
            }
            Console.WriteLine($"Произведение ненулевых: {mult}");

            foreach (int number in is_even)
            {
                count += 1;
            }
            Console.WriteLine($"Кол-во чётных: {count}");

            Console.ReadKey();
        }
    }
}
