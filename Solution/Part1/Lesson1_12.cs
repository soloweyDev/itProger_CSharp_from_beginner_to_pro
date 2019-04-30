using System;

namespace Part1
{
    /*
     Создайте интерфейс IWalk, вмещающий лишь одну функцию. Данная функция ничего не возвращает и лишь выводит информацию в консоль.
     Создайте три класса: Dog, Cat, Fish. В каждом из классов реализуйте интерфейс IWalk.
     В главном классе создайте объект на основе одного из классов и вызовите метод из класса.
     */

    public interface IWalk
    {
        void Info();
    }

    public class Dog : IWalk
    {
        public void Info()
        {
            Console.WriteLine("Dog");
        }
    }

    public class Cat : IWalk
    {
        public void Info()
        {
            Console.WriteLine("Cat");
        }
    }

    public class Fish : IWalk
    {
        public void Info()
        {
            Console.WriteLine("Fish");
        }
    }

    public class Lesson1_12
    {
        internal static void Test()
        {
            Dog dog = new Dog();
            dog.Info();

            Cat cat = new Cat();
            cat.Info();

            Fish fish = new Fish();
            fish.Info();
        }
    }
}
