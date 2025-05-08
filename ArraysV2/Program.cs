using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] MyArray = { 88, 23, 45, 67, 45, 23, 95, 241, 356, 246 };

            //Console.WriteLine(MyArray.Max()); максимальный элемент массива

            //Console.WriteLine(MyArray.Min()); минимальный элемент массива

            //Console.WriteLine(MyArray.Sum()); сумма всех элементов значения

            //Console.WriteLine(MyArray.Where(i => i % 2 ==0).Sum()); сумма всех четных элементов массива

            //int[] MyArray2 = MyArray.Distinct().ToArray(); выводит массив только с уникальными значениями

            //int[] MyArray3 = MyArray.OrderBy(i => i).ToArray();  в порядке возростания 

            //int[] MyArray4 = MyArray.OrderByDescending(i => i).ToArray(); в порядке убывания

            //Array.Sort(MyArray); в порядке возростания

            //int result = Array.Find(MyArray, i => i > 200);    начинает поиск с начала массива

            //int result = Array.FindLast(MyArray, i => i > 200);  начинает поиск с конца массива

            //int[] result = Array.FindAll(MyArray, i => i > 200);  несколько элементов удовлетворяющие условию

            //int result = Array.FindIndexLast(MyArray, i => i == 30); находит индекс элемента массива c начала

            //int result = Array.FindLastIndex(MyArray, i => i == 241); находит индекс элемента массива с конца

            //Array.Reverse(MyArray); выводит массив в обратном порядке

            //int[] result = MyArray.Where(i  => i > 70).ToArray();   выводит все элементы массива больше какого то числа

            //int result = MyArray.Where(i => i > 70).First(); находит первый элемент массива больше какого то числа

            //int result = MyArray.Where(i => i < 0).FirstOrDefault(); находит первый элемент массива выполняюее условие
            //                                                         или выводит дефолтное значание в зависимости типа массива
            //                                                         (в данном случае 0)

            Console.ReadLine();
            
        }
    }
}
