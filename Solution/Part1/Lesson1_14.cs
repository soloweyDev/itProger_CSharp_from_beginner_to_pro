using System;
using System.Collections.Generic;
using System.Linq;

namespace Part1
{
    public static class Lesson1_14
    {
        /*
         Создайте делегат, неизвестное заранее количество параметров. Создайте две функции: первая будет высчитывать сумму из всех полученных чисел,
         вторая - считать среднее арифметическое. В делегат присвоите первую функцию, после чего добавьте к переменной делегата вторую функцию.
         */
        private static int Addition(List<int> list)
        {
            return list.Sum();
        }

        private static int Average(List<int> list)
        {

            return list.Sum() / list.Count;
        }

        delegate int Math(List<int> list);

        public static void Test1()
        {
            List<int> list = new List<int>() { 1, 2, 5, 6, 7, 4, 11 };

            Math math = Addition;
            Console.WriteLine(math(list));

            math = Average;
            Console.WriteLine(math(list));
        }

        /*
         Приведен массив строк:
         string[] countries = { "США", "Канада", "Франция", "Лондон", "Барселона" };
         Используйте LINQ команду StartsWith. При помощи StartsWith выведите на экран лишь страны из массива countries начинающиеся на букву "Л".
         */
        internal static void Test2()
        {
            string[] countries = { "США", "Канада", "Франция", "Лондон", "Барселона" };
            List<string> list = new List<string>();
            list.AddRange(countries.Where(x => x.StartsWith("Л")));

            foreach (var str in list)
                Console.WriteLine(str);
        }
    }
}
