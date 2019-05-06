using System;
using System.Threading;

namespace Part1
{

    public static class Lesson1_15
    {
        /*
         Создайте функцию и вызовите её в потоке данных. В потоковой функции, а также в функции Main выводите данные в консоль.
         Паузу между выводом текста установите равной 0 милисекунд.
         */
        private static void ThreadFunc()
        {
            Console.WriteLine("ThreadFunc");
            Thread.Sleep(0);
        }

        public static void Test()
        {
            Thread thread = new Thread(new ThreadStart(ThreadFunc));
            thread.Start();
            Console.WriteLine("thread start");
            Thread.Sleep(0);
        }
    }
}
