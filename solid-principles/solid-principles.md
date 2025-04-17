## SOLID Principles (design principles)
SOLID principles are the **design principles** that enable us to manage several software design problems. Robert C. Martin compiled these principles in the 1990s. These principles provide us with ways to move from **tightly coupled code** and little encapsulation to the desired results of **loosely coupled** and **encapsulated real business** needs properly.

The following are the design flaws that **cause damage to software**, mostly.
1. Putting more stress on classes by assigning **more responsibilities** to them (a lot of functionality not related to the class).
2. **Forcing the classes to depend on each other**. If classes depend on each other (in other words, **tightly coupled**), then a change in one will affect the other.
3. **Spreading duplicate code in the system/application.**

Solutions:
1. Choosing the correct architecture (MVC, 3-tier, Layered, MVP, MVVP and so on...)
2. Following Design Principles
3. Choosing the correct Design Patterns to build the software based on its specifications.

### Single Responsibility Principle (SRP):
SRP says, **"Every software module should have only one reason to change"**. Every class or similar structure in our code should have only one job. Everything in that class should be related to a single purpose.  
Our class should not be like a Swiss Knife where in if one of them needs to be changed, the entire tool needs to be altered. It does not mean that our classes should only contain one method or property. There may be many members as long as they relate to a single responsibility.

### Open Closed Principle (OCP):
The **Open/Closed Principle** says, **"A software module/class is open for extension and closed for modification"**. 
**"Open for extension"** means we must design our module/class so that new functionality can be added only when new requirements
are generated. 
**"Closed for modification"** means we have already developed a class, and it has gone through unit testing. We should then not alter it until we find bugs. As it says, a class should be open for extensions; we can use inheritance.

### Liskov Substitution Principle (LSP):
The **Liskov Substitution Principle (LSP)** states, **"you should be able to use any derived class instead of a parent class and have it behave in the same manner without modification"**. It ensures that a derived class does not affect the behavior of the parent class; in other words, a derived class must be substitutable for its base class.
This principle is just and extension of the Open Closed Principle, and we must ensure that newly derived classes extend the base classes without **changing their behavior**.

### Interface Segregation Principle (ISP):
The **Interface Segregation Principle** states **"that clients should not be forced to implement interfaces they don't use. Instead of one fat interface, many small interfaces are preferred based on groups of methods, each serving one submodule"**.
An interface should have a specific purpose/responsibility (refer to SRP).  
We shouldn't be forced to implement an interface when our object doesn't **share that purpose**. The larger the interface, the more likely it includes methods not all implementers can use.

### Dependency Inversion Principle (DIP):
The **Dependency Inversion Principle (DIP)** states that **high-level modules/classes** should not depend on **low-level modules/classes**
1. Both should depend upon abstractions. 
2. Abstractions should not rely upon details. 
3. Details should depend upon abstractions.

A high-level module/class that depends on low-level modules/classes or some other class and **knows a lot** about the other classes it interacts with is said to be **tightly coupled**. When a class knows explicitly about the **design and implementation** of another class, it raises the **risk that changes to one class will break the other**.
To do that, we need to make both of them dependent on abstractions instead of **knowing each other**.
