// Search Task for Task 4 : 
When Should I Use a Struct Instead of a Class in C#?
In C#, the main difference between a class and a struct is how they are stored and handled in memory.
A class is a reference type, while a struct is a value type.
You should use a struct instead of a class when:
The object is small and lightweight.
The object represents a single value or a simple data structure (like coordinates, color, or a point).
The object does not need inheritance.
You do not need complex behavior.
The object should behave like a value (copied completely when assigned).
Avoid using struct when:
The object is large.
You need inheritance.
The object has complex logic.
It will be passed frequently as a parameter (because copying large structs is expensive).
=========================================================================================
Record vs Struct vs Class in C#
Class:
Type: Reference Type
Equality: Uses reference equality by default.
Supports inheritance.
Suitable for objects that have identity (like User, Product, Order).
Can contain both data and behavior.
Struct:
Type: Value Type
Equality: Value-based equality (compares fields).
Does not support inheritance (except interfaces).
Best for small, simple data structures.
Stored directly where declared (more memory efficient for small data).
Record:
Introduced in C# 9.
Default Type: Reference Type.
Equality: Value-based equality by default.
Designed mainly for data models and DTOs.
Often immutable.
Supports inheritance.
There is also Record Struct (introduced in C# 10):
It is a value type.

Provides value-based equality.

Useful for small immutable data structures.
