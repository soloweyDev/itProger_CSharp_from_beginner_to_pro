using System;

namespace Part1
{
    /*
     Создайте класс «Дом» (House) со следующими его характеристиками:
     • количество этажей (floors);
     • год постройки (year);
     • название (предназначение) дома (name);
     На основании класса «Дом» создайте два объекта и, используя метод класса, пропишите для каждого их уникальные характеристики. Выведите информацию о каждом объекте, используя метод класса.
     Создайте метод, который будет показывать (возвращать) возраст дома (количество лет прошедших с момента постройки дома по сегодняшний год). В классе «Дом» (House) создайте три конструктора:
     1. Конструктор по умолчанию, который выводит сообщение “Empty constructor!”.
     2. Конструктор, который устанавливает год постройки и название дома;
     3. Конструктор, который устанавливает все переменные класса.
     */

    public class House
    {
        private short floors;
        private short year;
        private string name;

        public House()
        {
            Console.WriteLine("Empty constructor!");
        }

        public House(short year, string name)
        {
            this.year = year;
            this.name = name;
        }

        public House(short floors, short year, string name)
        {
            this.floors = floors;
            this.year = year;
            this.name = name;
        }

        public void Info()
        {
            Console.WriteLine($"floors: {floors} year: {year} name: {name}");
        }

        public int GetAgeHouse(int year)
        {
            return year - this.year;
        }
    }

    static class Lesson1_9
    {
        static public void Test()
        {
            House house1 = new House(1980, "Test1");
            House house2 = new House(4, 1983, "Test2");

            house1.Info();
            house2.Info();

            Console.WriteLine(house1.GetAgeHouse(2000));
            Console.WriteLine(house2.GetAgeHouse(2000));
        }
    }
}
