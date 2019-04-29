using System;

namespace Part1
{
    /*
     Добавьте новый класс Грузовик и сделайте его классом наследником класса Car. В классе Грузовик создайте переменные:
     количество колес и максимальный вес. Создайте метод newWheels, который будет устанавливать значение в переменную
     "количество колёс" и выводить все данные из класса в консоль.
     Также создайте конструктор в главном классе для присвоения всех переменных. В классе наследнике создайте конструктор,
     устанавливающий все значения в конструктор главного класса и дополнительно переменные в класс Грузовик.
     */

    public class Car
    {
        protected int weight;
        protected string model;
        protected char color;
        protected float speed;

        public Car(int weight, string model, char color, float speed)
        {
            this.weight = weight;
            this.model = model;
            this.color = color;
            this.speed = speed;
    }

        public void outPut()
        {
            Console.WriteLine("Weight of " + model + " is " + weight + "kg.");
            Console.WriteLine("Color is " + color + " and it speed - " + speed);
        }
    }

    public class Truck : Car
    {
        private short numberWheels;
        private uint maxWeight;

        public Truck(int weight, string model, char color, float speed, short numberWheels, uint maxWeight) : base(weight, model, color, speed)
        {
            this.numberWheels = numberWheels;
            this.maxWeight = maxWeight;
        }

        public void newWheels(short wheels)
        {
            numberWheels = wheels;

            Console.WriteLine($"Колес: {numberWheels}, максимальный вес {maxWeight}");
        }
    }

    static class Lesson1_10
    {
        static public void Test()
        {
            Truck truck = new Truck(1000, "bmw", 'r', 250.5f, 4, 2500);
            truck.newWheels(5);
            truck.outPut();
        }
    }
}
