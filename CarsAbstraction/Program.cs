using System;

namespace CarsAbstraction
{
    interface IMovable
    {
        string Model { get; set; }
        void Move(); 
    }

    class Car: IMovable
    {
        public string Model { get; set; }

        public Car(string model)
        {
            Model = model;
        }

        public void Move()
        {
            Console.WriteLine("Рулю с удовольствием");
        }
    }

    class MinCar : IMovable
    {
        public string Model { 
            get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); 
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }

    class ComplexCar : IMovable
    {
        public string color;
        public string Model { get; set; }
        public ComplexCar(string model, string color)
        {
            Model = model;
            this.color = color;
        }
        public void Move()
        {
            Console.WriteLine("Рулю с удовольствием быстро");
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

            var bygatti = new ComplexCar("bygatti", "ComplexCar");
            driver.car = bygatti;
            driver.car.Move();
            Console.WriteLine(driver.car.Model);
            Console.ReadKey();
        }
    }
}
