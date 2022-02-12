using System;

namespace Variables
{
    class Product1
    {
        public string name;
        public void GetInfo()
        {
            Console.WriteLine($"Название товара: {name}");
            Console.WriteLine();
        }
    }
    class Product2
    {
        public string name;
        public Product2(string name)
        {
            this.name = name;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Название товара: {name}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var pen = new Product1();
            var pencil = new Product2("Карандаш");
            pen.name = "Ручка";
            pen.GetInfo();
            pencil.GetInfo();
        }
    }
}
