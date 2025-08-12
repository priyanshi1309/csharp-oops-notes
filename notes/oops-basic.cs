
using System;

namespace OOPBasicsDemo
{
    // 1. Class and Object
    public class Person
    {
        public string Name { get; set; }
        public void Introduce() => Console.WriteLine($"Hi, I'm {Name}");
    }

    // 2. Properties and Fields
    public class Car
    {
        private string model;
        public string Model
        {
            get => model;
            set => model = value;
        }
    }

    // 3. Methods
    public class Calculator
    {
        public int Add(int a, int b) => a + b;
    }

    // 4. Constructor
    public class Student
    {
        public string Name { get; set; }
        public Student(string name)
        {
            Name = name;
        }
        public void Display() => Console.WriteLine($"Student Name: {Name}");
    }

    // 5. Access Modifiers
    public class Example
    {
        private int secretNumber;
        public Example(int number)
        {
            secretNumber = number;
        }
        public void ShowNumber() => Console.WriteLine(secretNumber);
    }

    // 6. Static Members
    public class Counter
    {
        public static int Count = 0;
        public Counter()
        {
            Count++;
        }
    }

    // 7. Const vs Readonly
    public class ConstantsDemo
    {
        public const double Pi = 3.14159; // Compile-time constant
        public readonly DateTime CreatedOn; // Runtime constant

        public ConstantsDemo()
        {
            CreatedOn = DateTime.Now; // Allowed in constructor
        }

        public void ShowValues()
        {
            Console.WriteLine($"Pi: {Pi}");
            Console.WriteLine($"CreatedOn: {CreatedOn}");
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Class and Object
            Person p = new Person { Name = "Alice" };
            p.Introduce();

            // 2. Properties and Fields
            Car car = new Car();
            car.Model = "Tesla";
            Console.WriteLine(car.Model);

            // 3. Methods
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(5, 3));

            // 4. Constructor
            Student s = new Student("John");
            s.Display();

            // 5. Access Modifiers
            Example ex = new Example(42);
            ex.ShowNumber();

            // 6. Static Members
            Counter c1 = new Counter();
            Counter c2 = new Counter();
            Console.WriteLine(Counter.Count);

            // 7. Const vs Readonly Example
            ConstantsDemo constants = new ConstantsDemo();
            constants.ShowValues();
        }
    }
}
