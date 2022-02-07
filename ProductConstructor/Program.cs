using System;

namespace ProductConstructor
{
    class Product
    {
        public string name;
        public string description;
        public double price;
        public int quantity;

        public Product(string name, string description, double price, int quantity )
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.quantity = quantity;
            
        }
         public void GetInfo()
        {
            Console.WriteLine($"Название товара: {name}");
            Console.WriteLine($"Описание: {description}");
            Console.WriteLine($"Цена: {price}" + " руб.");
            Console.WriteLine($"Количество: {quantity}" + " шт.");
            Console.WriteLine();

        }
        class Program
        {
            static void Main()
            {
                var pencil = new Product("Карандаш", "Прекрасный карандаш для ваших зарисовок", 14.5, 1);
                var pen = new Product("Ручка", "Великолепная ручка для записей", 20.2, 1);
                var ruler = new Product("Линейка", "Восхитительная линейка для ровных чертежей", 10.4, 1);
                pencil.GetInfo();
                pen.GetInfo();
                ruler.GetInfo();
            }
        }
    }
}
