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
```csharp
---
In the above example:

- `b2.Show()` calls the base class method because the base class reference is used, and `Show()` in `Derived` hides, not overrides.
- If `Show()` in `Derived` was marked with `override` instead of `new`, then `b2.Show()` would output "Derived Show".

---
