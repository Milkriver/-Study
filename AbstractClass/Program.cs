using System;

namespace AbstractClass
{
    interface IMovable
    {
        string Model { get; set; }
        void Move();
    }

    abstract class CarBase : IMovable
    {
        public string Model { get; set; } = "Безымянная модель";
        public virtual void Move()
        {
            Console.WriteLine("Рулю с удовольствием в базовом классе");
        }
    }

    class Car : CarBase, IMovable
    {
        public Car(string model)
        {
            Model = model;
        }

        public override void Move()
        {
            base.Move();
            Console.WriteLine("Рулякаю с удовольствием в дочернем классе");
        }
    }

       class ComplexCar : CarBase
    {
        private string color;
        public ComplexCar(string model, string color)
        {
            Model = model;
            this.color = color;
        }
    }

    class Driver
    {
        public IMovable car;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var lada = new Car("lada");
            var driver = new Driver();
            driver.car = lada;
            Console.WriteLine(driver.car.Model);
            driver.car.Move();

            var bygatti = new ComplexCar("bygatti", "ComplexCar");
            driver.car = bygatti;
            //bygatti.color; - Инкапсуляция
            driver.car.Move();
            Console.WriteLine(driver.car.Model);
            Console.ReadKey();
        }
    }
}
