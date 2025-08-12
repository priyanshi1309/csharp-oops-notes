# OOP Basics in C#

Object-Oriented Programming (OOP) is a programming paradigm that organizes software design around **objects**, which contain **data** (fields/properties) and **behavior** (methods).

---

## 1. Class and Object
- **Class**: A blueprint for creating objects.
- **Object**: An instance of a class.

```csharp
public class Person
{
    public string Name { get; set; }
    public void Introduce() => Console.WriteLine($"Hi, I'm {Name}");
}

Person p = new Person { Name = "Alice" };
p.Introduce();

## 2. Properties and Fields
- **Field**: A variable defined inside a class that holds data.
- **Property**: Provides controlled access to fields using `get` and `set`.

```csharp
public class Car
{
    private string model;
    public string Model
    {
        get => model;
        set => model = value;
    }
}
Car car = new Car();
car.Model = "Tesla";
Console.WriteLine(car.Model);

## 3. Methods
- A block of code inside a class that performs a specific task.

```csharp
public class Calculator
{
    public int Add(int a, int b) => a + b;
}
Calculator calc = new Calculator();
Console.WriteLine(calc.Add(5, 3));

## 4. Constructor
A constructor is a special method that initializes objects.  
It has the same name as the class and no return type.

```csharp
public class Student
{
    public string Name { get; set; }
    
    public Student(string name)
    {
        Name = name;
    }

    public void Display() => Console.WriteLine($"Student Name: {Name}");
}

Student s = new Student("John");
s.Display(); // Output: Student Name: John


## 5. Access Modifiers
Control the visibility of class members:
- `public` – Accessible from anywhere.
- `private` – Accessible only within the class.
- `protected` – Accessible within the class and derived classes.
- `internal` – Accessible within the same assembly.
- `protected internal` – Accessible within the same assembly or derived classes.

```csharp
public class Example
{
    private int secretNumber;

    // Constructor (public so it can be accessed from outside)
    public Example(int number)
    {
        secretNumber = number;
    }

    public void ShowNumber() => Console.WriteLine(secretNumber);
}

Example ex = new Example(42);
ex.ShowNumber(); // Output: 42


## 6. Static Members
Static members belong to the class rather than an instance.

```csharp
public class Counter
{
    public static int Count = 0;

    public Counter()
    {
        Count++;
    }
}

Counter c1 = new Counter();
Counter c2 = new Counter();
Console.WriteLine(Counter.Count); // Output: 2

