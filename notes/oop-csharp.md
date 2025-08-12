# OOP Basics in C#

**Object-Oriented Programming (OOP)** is a programming paradigm that organizes software design around **objects**, which combine:
- **Data** (Fields, Properties)
- **Behavior** (Methods, Events)

This document covers **basic OOP concepts in C#** that are common in beginner-level interviews.

---

## 1. Class and Object
- **Class**:  
  A *blueprint* or *template* used to create objects.  
  It defines properties (data) and methods (behavior) that its objects will have.
  
- **Object**:  
  An **instance** of a class.  
  Each object has its own values for the properties but shares the same behavior definitions.

- **Key Points**:
  - A class is a logical definition, not a physical entity.
  - Objects exist at runtime and consume memory.

---

## 2. Properties and Fields
- **Field**:
  - A variable inside a class that stores data.
  - Usually marked `private` for encapsulation.
  
- **Property**:
  - Provides controlled access to fields.
  - Can include `get` (read) and `set` (write) accessors.
  - Supports validation, computed values, or access restriction.

---

## 3. Methods
- **Definition**:  
  A named block of code that performs a specific task.
  
- **Types**:
  - **Instance Methods**: Require an object to call them.
  - **Static Methods**: Belong to the class, not an instance.
  - **Overloaded Methods**: Same name, different parameter list.

- **Why Methods?**
  - Reuse code
  - Organize logic
  - Reduce redundancy

---

## 4. Constructor
- **Purpose**:  
  Special method used to initialize objects when they are created.
  
- **Rules**:
  - Same name as the class.
  - No return type.
  - Can be overloaded with different parameter lists.
  
- **Types**:
  - **Default Constructor**: No parameters.
  - **Parameterized Constructor**: Accepts parameters to initialize fields/properties.
  - **Static Constructor**: Initializes static data; runs once per class.

---

## 5. Access Modifiers
Control how class members are accessed:

| Modifier            | Scope                                                                 |
|---------------------|------------------------------------------------------------------------|
| `public`            | Accessible anywhere.                                                   |
| `private`           | Accessible only inside the same class.                                 |
| `protected`         | Accessible in the same class and derived classes.                      |
| `internal`          | Accessible within the same assembly.                                   |
| `protected internal`| Accessible within the same assembly or derived classes in other assemblies. |
| `private protected` | Accessible within the same assembly and only in derived classes.       |

---

## 6. Static Members
- Belong to the class, not individual objects.
- Shared across all instances.
- Common for constants, utility methods, and counters.

**Types**:
- **Static Fields**: One shared value for all objects.
- **Static Methods**: Can be called without creating an object.
- **Static Constructors**: Initialize static members; runs once before use.

---

## 7. Constants and Readonly
- **const**:
  - Compile-time constant.
  - Value must be assigned at declaration.
  - Cannot be changed later.
  
- **readonly**:
  - Value can be assigned at declaration or inside a constructor.
  - Value cannot be modified after object creation.
  
- **Key Difference**:
  - `const` is fixed at compile time.
  - `readonly` can vary per object (set in constructor) but is immutable afterward.

---

## 8. this Keyword
- Refers to the **current instance** of the class.
- Common uses:
  - Differentiate between method parameters and fields with the same name.
  - Pass the current object to another method or constructor.
  - Chain constructors using `this()`.

---

## 9. var, dynamic, and object
- **var**:
  - Statically typed (type decided at compile time).
  - Requires initialization at declaration.
  
- **dynamic**:
  - Type determined at runtime.
  - No compile-time checking (may cause runtime errors).
  
- **object**:
  - Base type for all data types in C#.
  - Requires casting for specific type usage.

---

## 10. Nullable Types
- Allows value types (like `int`) to hold `null`.
- Declared with `?` after the type:  
  Example: `int? age = null;`
- Useful when data is optional.

---

## 11. Difference between Value Types and Reference Types
| Feature           | Value Type                     | Reference Type          |
|-------------------|--------------------------------|-------------------------|
| Storage           | Stack                          | Heap                    |
| Examples          | int, bool, struct              | class, string, array    |
| Assignment        | Copy of the value              | Copy of the reference   |
| Nullability       | Cannot be null (unless nullable)| Can be null             |

---

## 12. Partial Classes
- Allows a class to be split into multiple files.
- All parts are combined at compile time.
- Useful for large classes or when auto-generated code is involved.

---

## 13. Sealed Classes
- A **sealed class** cannot be inherited.
- Used to prevent extension of a class for security or design reasons.

---

## 14. Anonymous Types
- Allow creation of an object without explicitly defining a class.
- Properties are read-only.
- Common in LINQ queries.

Example in concept:  
`var person = new { Name = "John", Age = 30 };`

---

