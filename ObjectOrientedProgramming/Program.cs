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
        public string Inn { get; private set; }

        public Employee(string name, int age, string inn)
            : base(name, age) 
        {
            Inn = inn;

        }  
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var e = new Employee("Anton", 32, "123inn");
            Console.WriteLine(e.Inn);
        }
    }
}
