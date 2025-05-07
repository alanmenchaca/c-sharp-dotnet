**Singleton** is a creation design pattern that lets you ensure that a class has **only one instance**, while providing a **global access point** to this instance.

### Problem
The singleton pattern solvers two problems, at the same time, violating the *Single Responsibility Principle*:
1. **Ensure that a class has just a single instance**. The most common reason for wanting to control the number of instances a class has is to **manage access** to a **shared resource**, such as a database or a file2
2. **Provide a global access point to that instance**. The singleton pattern lets you access some object from anywhere in the program. However, it also protects that instance from being overwritten by other code.
Nowadays, the singleton pattern has become so popular that people may call something a *singleton* even if it solves just one of the listed problems.

### Solution
All implementations of the Singleton have these two steps in common:
* Make the default constructor private, to prevent other objects from using the `new` operator with the Singleton class.
* Create a static creation method that acts as a constructor. Under the hood, this method calls the private constructor to create and object and saves it in a static field. All following calls to this method return the cached object.
If your code has access to the Singleton class, then it's able to call the Singleton's static method. So whenever that method is called, the same object is always returned.

![[singleton-structure.png]]

### Applicability
*  Use the Singleton pattern when a class in your program should have **just a single instance available** to all clients; for example, a single database object shared by different parts of the program.
	* The Singleton pattern disables all other mean of creating objects of a class except for the special creation method. This method either creates a new object or returns an existing one if it has already been created.
* Use the Singleton pattern when you need **stricter control over global variables**.
	* Unlike global variables, the Singleton pattern guarantees that there's just one instance of a class. Nothing, except for the Singleton class itself, can replace the cached instance.

### How to Implement
1. Add a private static field to the class for storing the singleton instance.
2. Declare a public static creation method for getting the singleton instance.
3. Implement "lazy initialization" inside the static method. It should create a new object on its first call and put it into the static field. The method should always return that instance on all subsequent calls.
4. Make the constructor of the class private. The static method of the class will still be able to call the constructor, but not other objects.
5. Go over the client code and replace all direct calls to the singleton's constructor with calls to its static creation method.