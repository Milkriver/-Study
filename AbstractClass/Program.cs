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
        public ComplexCar(string model)
        {
            Model = model;
        }
    }

    class Driver
    {
        public IMovable car;
    }
    class Program
    {
        static void Main()
        {
            var lada = new Car("lada");
            var driver = new Driver
            {
                car = lada
            };
            Console.WriteLine(driver.car.Model);
            driver.car.Move();

            var bygatti = new ComplexCar("bygatti");
            driver.car = bygatti;
            driver.car.Move();
            Console.WriteLine(driver.car.Model);
            Console.ReadKey();
        }
    }
}
