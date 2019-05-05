namespace Part1
{
    /*
     Создайте структуру, которая будет описывать характеристики компьютера: процессор, вес, время автономной работы, количество ядер, установленная ОС.
     На основе такой структуры создайте объект и присвойте ему пару значений.
     */
    struct Computer
    {
        string proc;
        float weight;
        float timeWork;
        short numberCores;
        string os;

        public Computer(string proc, float weight, float timeWork, short numberCores, string os)
        {
            this.proc = proc;
            this.weight = weight;
            this.timeWork = timeWork;
            this.numberCores = numberCores;
            this.os = os;
        }
    }

    public static class Lesson1_13
    {
        public static void Test()
        {
            Computer computer1 = new Computer("AMD", 15.5f, 0.0f, 6, "Windows");
            Computer computer2 = new Computer("Intel", 12.5f, 1.1f, 2, "MacOS");
        }
    }
}
