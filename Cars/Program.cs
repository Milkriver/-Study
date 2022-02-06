using System;
using System.Collections.Generic;

namespace Cars
{
    class Car
    {
        public string model;

        public Car(string model)
        {
            this.model = model;
        }

        public void Go()
        {
            Console.WriteLine("Рулю с удовольствием");
        }
    }

    class ComplexCar
    {
        public string model;
        public string color;
        public ComplexCar(string model, string color)
        {
            this.model = model;
            this.color = color;
        }

        public void Go()
        {
            Console.WriteLine("Рулю с удовольствием");
        }
    }

    class Driver
    {
        //public Any Car maybe Car maybe ComplexCar;
        public ComplexCar maxi;
        public Car mini;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var lada = new Car("lada");
            var driver = new Driver();
            driver.mini = lada;
            driver.mini.Go();

            var bygatti = new ComplexCar("bygatti", "ComplexCar");
            driver.maxi = bygatti;
            driver.maxi.Go();
            Console.ReadKey();
        }
    }
}
