using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayV1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите количество элементов массива:\t");
            int elementsCount = int.Parse(Console.ReadLine());
            int[] MyArray = new int[elementsCount];

            for (int i = 0; i < MyArray.Length; i++)
            {
                Console.Write($"\nВведите элемент значения под индексом {i}:\t");
                MyArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("Вывод массива: ");
            Console.WriteLine(string.Join(" ", MyArray)); //Первый способ вывода массива с пробелами

            Console.Write("Вывод массива в обратном порядке: ");
            for (int i = MyArray.Length - 1; i >= 0; i--)
            {
                Console.Write(MyArray[i] + " "); //Второй способ вывода массива с пробелами
            }

            Console.WriteLine(); 

            // Подсчет четных чисел
            int Number = 0;
            int NumberSum = 0;
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] % 2 == 0)
                {
                    Number++;
                    NumberSum += MyArray[i];
                }
            }
            Console.WriteLine("\nСумма четных чисел в массиве: " + NumberSum);
            Console.WriteLine("Кол-во четных чисел в массиве: " + Number);

            // Поиск min и max
            int minValue = MyArray[0];
            int maxValue = MyArray[0];
            for (int i = 0; i < MyArray.Length; i++)
            {
                if (MyArray[i] < minValue)
                {
                    minValue = MyArray[i];
                }
                else if (MyArray[i] > maxValue)
                {
                    maxValue = MyArray[i];
                }
            }
            Console.WriteLine("\nМинимальное число в массиве равно: " + minValue);
            Console.WriteLine("Максимальное число в массиве равно: " + maxValue);

            Console.ReadLine();

        }
    }
}
