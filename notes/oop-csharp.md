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

