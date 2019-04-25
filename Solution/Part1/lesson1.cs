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

        /*
         Выведите столбец чисел от 25 до 29 с пропуском числа 27. Используйте цикл for, а также сделайте тоже самое с циклом while.
         */
        static public void Lesson1_5_1()
        {
            for (short i = 25; i < 29; ++i)
            {
                if (i == 27)
                    continue;

                Console.WriteLine(i);
            }

            Console.WriteLine();

            short j = 25;
            while (j < 29)
            {
                if (j != 27)
                    Console.WriteLine(j);

                j++;
            }
        }

        /*
         Создайте бесконечный цикл. Каждый раз просите пользователя чтобы тот что-то ввел с клавиатуры. После того, как он введет число 0 вы выйдите из цикла.
         Если пользователь введет число 1, то будет пропущена одна итерация цикла. За каждую итерацию цикла выводите сообщение "One more iteration".
         */
        static public void Lesson1_5_2()
        {
            string input;

            do
            {
                Console.WriteLine("Enter value (0 - exit, 1 - skip or other)");
                input = Console.ReadLine();

                if (input != "1")
                    Console.WriteLine("One more iteration");
            }
            while (input != "0");
        }

        /*
         Создайте двумерный массив и найдите минимальный элемент среди всех чисел в массиве. Массив: { { 0, 34, -2 }, { 3, -4, 5 } }
         */
        static public void Lesson1_5_3()
        {
            Int16[,] arr = { { 0, 34, -2 }, { 3, -4, 5 } };
            Int16 min = arr[0, 0];

            foreach (Int16 element in arr)
            {
                if (min > element)
                    min = element;
            }

            Console.WriteLine("min = " + min);
        }

        /*
         Создайте динамический массив чисел. Добавьте в него 7 элементов. При помощи цикла for найдите максимальный элемент в массиве.
         */
        static public void Lesson1_5_4()
        {
            List<float> arr = new List<float>() { 3.2f, 3.4f, 1.6f, 3.5f, 8.1f, 1.9f, 0.1f };

            float max = arr[0];
            for (byte i = 1; i < arr.Count; ++i)
            {
                if (max < arr[i])
                    max = arr[i];
            }

            Console.WriteLine(max);
        }

        /*
         Создайте функцию, которая будет принимать 2 параметра (время и скорость) и возвращать сколько проедет километров человек исходя из параметров.
         С функции необходимо передавать не только данные обратно при помощи return, но и вывести результат на экран. Если человек проедет 1 километр, то пишите:
         "Вы проедете: 1 километр", иначе пишите так: "Вы проедете: {здесь цифра} километров". Проверку на вывод информации осуществите через вторую функцию,
         которую вызывайте изнутри первой.
         */
        static public float Lesson1_6_1(float time, float speed)
        {
            float lenth = time * speed;

            Console.WriteLine(Lesson1_6_2(lenth) ? "Вы проедете: 1 километр" : $"Вы проедете: {lenth} километров");

            return lenth;
        }

        // 2 функция
        static public bool Lesson1_6_2(float lenth)
        {
            return lenth == 1;
        }
    }
}