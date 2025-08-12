# Intermediate OOP Interview Questions

This file covers common intermediate Object-Oriented Programming questions with explanations and examples, suitable for candidates with some experience in OOP.

---

## 1. What is the difference between **abstract class** and **interface**?

| Abstract Class                      | Interface                             |
|-----------------------------------|-------------------------------------|
| Can have implemented and abstract methods | Can only have method declarations (before C# 8.0) |
| Can have fields and constructors  | Cannot have fields or constructors  |
| Supports inheritance              | Supports multiple implementations   |

---

## 2. What is **method hiding** and how is it different from **method overriding**?

- **Method Overriding**:  
  The derived class provides a new implementation of a base class method that is marked `virtual` in the base class, by using the `override` keyword. This allows polymorphic behavior, meaning the overridden method will be called based on the runtime type of the object.

- **Method Hiding**:  
  The derived class declares a method with the same name as a base class method, using the `new` keyword. This hides the base class method instead of overriding it. When called through a base class reference, the base class version is used; when called through a derived class reference, the new method is used.

### Example in C#:

```csharp
class Base
{
  public virtual void Show() { Console.WriteLine("Base Show"); }
}

class Derived : Base
{
  public new void Show() { Console.WriteLine("Derived Show"); }
}

class Program
{
  static void Main()
  {
      Base b1 = new Base();
      b1.Show(); // Output: Base Show
      Derived d1 = new Derived();
      d1.Show();  // Output: Derived Show

      Base b2 = new Derived();
      b2.Show();  // Output: Base Show
  }
}
```
---
In the above example:

- `b2.Show()` calls the base class method because the base class reference is used, and `Show()` in `Derived` hides, not overrides.
- If `Show()` in `Derived` was marked with `override` instead of `new`, then `b2.Show()` would output "Derived Show".

---
## 3. Explain sealed classes and sealed methods.

- **Sealed Class:** Cannot be inherited.

- **Sealed Method:** Cannot be overridden further in subclasses.

---

## 4. What is the difference between composition and aggregation?

- **Composition:** Strong ownership, parts cannot exist without the whole.

- **Aggregation:** Weak ownership, parts can exist independently.

---

## 5. What are virtual, override, and abstract keywords?

- **virtual:** Base class method that can be overridden.

- **override:** Derived class method overriding a virtual method.

- **abstract:** Declares a method with no implementation; must be overridden.
---
## 6. What is the difference between shallow copy and deep copy?

- **Shallow Copy:** Copies the object’s references, so the new object points to the same referenced objects.
- **Deep Copy:** Creates a new object and recursively copies all objects it references, creating fully independent copies.

---

## 7. What is constructor chaining?

Calling one constructor from another constructor in the same class or base class to avoid code duplication.

Example:

```csharp
public class Person
{
    public string Name;
    public int Age;

    public Person() : this("Unknown", 0) { }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
```
---
## 8. How does C# implement multiple inheritance?

C# does **not** support multiple inheritance with classes, but supports it through **interfaces**.

---

## 9. What is method hiding? How is it different from method overriding?

- **Method Overriding:** Uses `virtual` and `override` keywords to provide a new implementation for a base class method.

- **Method Hiding:** Uses the `new` keyword to hide the base class method without overriding it.

---

## 10. What are access modifiers and explain `protected internal`?

- `public`: Accessible anywhere.

- `private`: Accessible only within the class.

- `protected`: Accessible within the class and derived classes.

- `internal`: Accessible within the same assembly.

- `protected internal`: Accessible within the same assembly or in derived classes.
---
## 11. What is the difference between an abstract class and a sealed class?

- **Abstract Class:** Cannot be instantiated and can contain abstract methods that must be implemented by derived classes.
- **Sealed Class:** Cannot be inherited by any other class.

---

## 12. What is an interface explicit implementation? Why use it?

- It allows implementing interface members so they are only accessible through the interface, not the class instance directly.

Example:

```csharp
interface IExample
{
    void DoWork();
}

class MyClass : IExample
{
    void IExample.DoWork()
    {
        Console.WriteLine("Explicit implementation");
    }
}
```
