using System;

namespace Variables
{
    class Product1
    {
        public string name;
        public string description;
        public void GetInfo()
        {
            Console.WriteLine($"Название товара: {name}");
            Console.WriteLine($"Описание товара: {description}");
            Console.WriteLine();
        }
    }
    class Product2
    {
        public string name;
        public string description;
        public Product2(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Название товара: {name}");
            Console.WriteLine($"Описание товара: {description}");
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            var pen = new Product1();
            var pencil = new Product2("Карандаш", "Описание карандаша");
            pen.name = "Ручка";
            pen.GetInfo();
            pencil.GetInfo();
        }
    }
}
