using System;

namespace ObjectOrientedProgramming
{
    public class Person
    {
        protected string name;
        protected int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    class Employee : Person
    {
        protected string _inn;

        public string InnWrapper {
            get => _inn;
            //string getInn () {
            // return _inn
            //}

            //private void setInn (string value) {
            // _inn = value
            //}
            private set
            {
                if (value.Length != 12)
                    throw new Exception();

                _inn = value;
            }
        }

        public string InnAutoWrapper { get; set; }

        public Employee(string name, int age, string inn)
            : base(name, age) 
        {
            //setInn(inn)
            InnWrapper = inn;
            InnAutoWrapper = inn;

        } 
        
        void SetInnExclusiveMethod (string governmentService, string newInn)
        {
            InnWrapper = newInn;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var e = new Employee("Anton", 32, "123inn");
            e.InnAutoWrapper = "123";
            Console.WriteLine(e.InnWrapper);
        }
    }
}
