# Four Pillars of OOP in C#

Object-Oriented Programming in C# is built on **four main principles** that help create flexible, reusable, and maintainable software.

---

## 1. Encapsulation

### Definition
Encapsulation is the process of **wrapping data (fields)** and **behavior (methods)** inside a single unit (class) and **restricting direct access** to the internal state of an object.

In simple terms:
> Hide the details, and provide controlled ways to access and modify the data.

---

### How It Works in C#
- Use **access modifiers** (`private`, `protected`, `public`, etc.) to limit direct access.
- Keep **fields** private and expose them via **properties** or **methods**.
- This ensures you can validate or transform the data before it is used.

---

### Real-World Analogy
Think of a **capsule pill**:  
You see the outer shell (interface to the outside), but the internal medicine is hidden. You can take the pill, but you cannot directly alter its contents.

---

### Benefits
- Prevents unauthorized access to sensitive data.
- Allows changes to internal implementation without affecting external code.
- Improves maintainability and security.

---

### Key Points
- Public fields break encapsulation — prefer private fields + public properties.
- Properties can have different access levels for `get` and `set`.

---

### Common Mistake
> Making all class members `public` just to “make it work” — this defeats the purpose of encapsulation.

---

## 2. Inheritance

### Definition
Inheritance allows a **derived class (child)** to acquire **fields, properties, and methods** from a **base class (parent)**.

This creates a relationship of **"is-a"** between the derived and base class.

---

### How It Works in C#
- Use `:` after the class name to indicate inheritance.
- The derived class can:
  - Use members of the base class.
  - Add new members.
  - Override virtual members.

---

### Real-World Analogy
A **Car** is a **Vehicle**.  
All vehicles have wheels, engines, and the ability to move. A car adds specific features like air conditioning and stereo.

---

### Benefits
- Promotes code reuse.
- Reduces duplication.
- Establishes a clear hierarchy.

---

### Types in C#
- **Single Inheritance**: One base → one derived.
- **Multilevel Inheritance**: Chain of inheritance (A → B → C).
- **Hierarchical Inheritance**: Multiple derived classes from one base.

---

### Key Points
- C# does **not** support multiple inheritance of classes (only interfaces).
- Use `base` keyword to call base class constructors/methods.

---

### Common Mistake
> Forcing inheritance where there’s no **is-a** relationship — should use **composition** instead.

---

## 3. Polymorphism

### Definition
Polymorphism means **"many forms"** — the ability of the same method name to perform different actions based on the object calling it.

---

### How It Works in C#
There are two main types:

#### 1. Compile-Time Polymorphism (Static Binding)
- Achieved using **method overloading**.
- Decided at compile time which method to call.

#### 2. Runtime Polymorphism (Dynamic Binding)
- Achieved using **method overriding** with `virtual` (in base) and `override` (in derived).
- The actual method executed is determined at runtime.

---

### Real-World Analogy
A **Remote Control** has a “power” button:
- For a TV, it turns the TV on/off.
- For an AC, it turns the AC on/off.
The action depends on the device (object) but the interface (button) is the same.

---

### Benefits
- Allows writing code that works with different object types without modification.
- Makes systems extensible — new behavior can be added without changing existing code.

---

### Key Points
- Overloading: Same method name, different parameters.
- Overriding: Same method signature, different implementation in a derived class.
- Mark base methods `virtual` or `abstract` for overriding.

---

### Common Mistake
> Forgetting `virtual` in base method or `override` in derived method — leading to hiding instead of overriding.

---

## 4. Abstraction

### Definition
Abstraction is about **hiding implementation details** and **showing only the essential features** of an object.

---

### How It Works in C#
- Use **abstract classes**:
  - Can contain abstract (no body) and non-abstract methods.
  - Cannot be instantiated.
  - Derived classes must implement abstract members.
- Use **interfaces**:
  - All members are abstract by default.
  - A class can implement multiple interfaces.

---

### Real-World Analogy
When you drive a car, you use the **steering wheel** and **pedals** without knowing the exact inner working of the engine.  
You know **what** it does, not **how** it does it.

---

### Benefits
- Reduces complexity.
- Focuses on what needs to be done, not how.
- Encourages multiple implementations for the same interface.

---

### Key Points
- Abstract classes allow partial implementation; interfaces do not.
- Use interfaces when you need multiple inheritance of behavior.
- Use abstraction to define **contracts** in your application.

---

### Common Mistake
> Using abstraction everywhere unnecessarily — this can overcomplicate simple systems.

---

## Quick Comparison Table

| Pillar         | Focus                                         | C# Features Used                                   |
|----------------|-----------------------------------------------|----------------------------------------------------|
| Encapsulation  | Hiding internal data & controlling access     | Access Modifiers, Properties                      |
| Inheritance    | Reusing and extending functionality           | `:` (extends), Base & Derived Classes              |
| Polymorphism   | Many forms of the same action                  | Method Overloading, Method Overriding (`virtual`, `override`) |
| Abstraction    | Hiding details, exposing only essentials      | Abstract Classes, Interfaces                       |

---
