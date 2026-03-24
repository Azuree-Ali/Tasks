// Search Task 6
protected internal:
This access modifier allows a member to be accessed from within the same assembly (project) OR from any derived class, even if it is in another assembly. It provides a wider level of accessibility and is useful when you want to allow both internal access and inheritance across projects.
=========================================
private protected:
This access modifier allows a member to be accessed only within derived classes AND only if those classes are in the same assembly. It is more restrictive and is used when you want to limit access strictly to inheritance within the same project.
========================================
Difference:
The key difference is that protected internal uses OR logic (same assembly or inheritance), while private protected uses AND logic (same assembly and inheritance).
