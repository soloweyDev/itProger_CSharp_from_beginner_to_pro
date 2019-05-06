using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Part1
{
    public static class Lesson1_16
    {
        /*
         Сохраните объекты класса Animal в формате JSON. Для этого рассмотрите работу с классом DataContractJsonSerializer.
         */
        public static void Test()
        {
            Animal cat = new Animal(30, "Tom");
            Animal mouse = new Animal(20, "Jerry");
            Animal dog = new Animal(40, "Booch");
            Animal[] animals = new Animal[] { cat, dog, mouse };

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Animal[]));

            using (FileStream fs = new FileStream("animals.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, animals);
            }
        }
    }

    [DataContract]
    public class Animal
    {
        [DataMember]
        public short age;
        [DataMember]
        public string name;

        public Animal(short age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
