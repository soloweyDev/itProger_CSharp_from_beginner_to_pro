using System;

namespace Part1
{
    /*
     Создайте абстрактный класс Человек. Создайте ещё два класса: Клиент и Работник банка. В классе Человек добавьте
     переменные: имя, фамилия, а также абстрактные методы: получение имени, получение фамилии, вывод всей информации
     из класса.
     В данном примере использование абстрактных классов оправдано, так как иные классы лишь имеют общие характеристики,
     но значение разные.
     В классах-наследниках реализуйте функции, а также добавьте по одной дополнительной переменной в каждый из классов.
     Создайте конструкторы в классах-наследниках, устанавливающие переменные в самом классе, а также передающие данные
     в главный конструктор для установки имени и фамилии.
     */
    public abstract class Person
    {
        protected string name;
        protected string lastname;

        protected Person(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }

        public abstract string GetName();
        public abstract string GetLastname();
        public abstract void Print();
    }

    public class Client : Person
    {
        private char level;

        public Client(string name, string lastname, char level) : base(name, lastname)
        {
            this.level = level;
        }

        public override string GetLastname()
        {
            return lastname;
        }

        public override string GetName()
        {
            return name;
        }

        public override void Print()
        {
            Console.WriteLine($"Клиент: {lastname} {name}. Уровень лояльности: {level}.");
        }

        public char GetLevel()
        {
            return level;
        }
    }

    public class EmployeeBank : Person
    {
        private string role;

        public EmployeeBank(string name, string lastname, string role) : base(name, lastname)
        {
            this.role = role;
        }

        public override string GetLastname()
        {
            return lastname;
        }

        public override string GetName()
        {
            return name;
        }

        public override void Print()
        {
            Console.WriteLine($"Работник банка: {lastname} {name}. Роль: {role}.");
        }

        public string GetRole()
        {
            return role;
        }
    }

    static class Lesson1_11
    {
        static public void Test()
        {
            Person client = new Client("Dima", "Ivanov", 'A');
            Person bank = new EmployeeBank("Valodya", "Putinin", "Admin");

            client.Print();
            bank.Print();
        }
    }
}
