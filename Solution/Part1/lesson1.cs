using System;

namespace Part1
{
    static class Lessons
    {
        /*
         * Создайте программу для ввода в консоль двух произвольных чисел. При помощи тернарного оператора сформулируйте ответ программы: либо деление полученных чисел, либо вывод 1
         */
        static public void Lesson1_1()
        {
            float a, b, res;

            Console.WriteLine("Enter 1 value: ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter 2 value: ");
            b = Convert.ToSingle(Console.ReadLine());

            res =  b != 0 ? a / b : 1;

            Console.WriteLine("Result: " + res);
        }
    }
}