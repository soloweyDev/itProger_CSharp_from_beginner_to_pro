using System;

namespace Part1
{
    static class Lessons
    {
        /*
         Создайте программу для ввода в консоль двух произвольных чисел. При помощи тернарного оператора сформулируйте ответ программы: либо деление полученных чисел, либо вывод 1
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
    }
}