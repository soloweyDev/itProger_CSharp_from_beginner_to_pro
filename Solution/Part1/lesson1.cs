using System;
using System.Collections.Generic;

namespace Part1
{
    static class Lessons
    {
        /*
         Создайте программу для ввода в консоль двух произвольных чисел. При помощи тернарного оператора сформулируйте ответ программы: либо деление полученных чисел,
         либо вывод 1
         */
        static public void Lesson1_3_1()
        {
            float a, b, res;

            Console.WriteLine("Enter 1 value: ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter 2 value: ");
            b = Convert.ToSingle(Console.ReadLine());

            res =  b != 0 ? a / b : 1;

            Console.WriteLine("Result: " + res);
        }

        /*
         С помощью оператора switch case напишите программный код, который попросит пользователя ввести два произвольных числа и выбрать одно из следующих арифметических
         действий: +, -, *, /. Результат действия вывести на экран.
         */
        static public void Lesson1_3_2()
        {
            float a, b;
            char c;

            Console.WriteLine("Enter 1 value: ");
            a = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter 2 value: ");
            b = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Enter operand (+, -, *, /): ");
            c = Convert.ToChar(Console.Read());

            switch(c)
            {
                case '+':
                    Console.WriteLine(a + b);
                    break;
                case '-':
                    Console.WriteLine(a - b);
                    break;
                case '*':
                    Console.WriteLine(a * b);
                    break;
                case '/':
                    if (b == 0)
                        Console.WriteLine("Division by zero");
                    else
                        Console.WriteLine(a / b);
                    break;
                default:
                    Console.WriteLine("Unknown operand");
                    break;
            }
        }

        /*
         Создайте два массива arr_1 и arr_2. Скопируйте данные из arr_1 в arr_2, а из arr_2 в arr_1, тем самым поменяйте их местами.
         */
        static public void Lesson1_4_1()
        {
            int[] arr_1 = { 1, 2, 3 };
            int[] arr_2 = { 4, 5, 6 };

            int temp = arr_1[0];
            arr_1[0] = arr_2[0];
            arr_2[0] = temp;

            temp = arr_1[1];
            arr_1[1] = arr_2[1];
            arr_2[1] = temp;

            temp = arr_1[2];
            arr_1[2] = arr_2[2];
            arr_2[2] = temp;
        }

        /*
         Создайте динамический массив состоящий из чисел с точкой. Добавьте в него 7 элементов. Выполните сортировку данных в массиве.
         */
        static public void Lesson1_4_2()
        {
            List<float> arr = new List<float>() { 3.2f, 3.4f, 1.6f, 3.5f, 8.1f, 1.9f, 0.1f };
            arr.Sort();
        }
    }
}