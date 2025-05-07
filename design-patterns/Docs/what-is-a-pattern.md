**Design patterns** are typical solutions to commonly occurring problems in software design. They are like pre-made blueprints that you can customize to solve recurring design problem in your code.
The pattern is not a specific piece of code, but a general concept for solving a particular problem.

### History of patterns
Patterns are **typical solutions** to **common problems** in object-oriented design. When a solution get repeated over and over in various projects, someone eventually puts a name to it and describes the solution in detail.
The idea was picked up by four authors (the gang of four) in their book **Design Patterns: Elements of Reusable Object-Oriented Software.**
Since then, dozens of other object-oriented patterns have been discovered. The "pattern approach" became very popular in other programming fields, so lots of other patterns now exist outside of object-oriented design as well.

### Why should I learn patterns?
* Design patterns are a toolkit of **tried and tested solutions** to common problems in software design. Knowing patterns is useful because it teaches you how to solve all sorts of problems using principles of object-oriented design.
* Design patterns define a common language that you and your teammates can use to communicate more efficiently. No need to explain what a singleton is if you know the pattern and its name.

### Criticism of patterns
#### Kludges for a weak programming Language
Usually the need for patterns arises when people choose a programming language or a technology that lacks the necessary level of abstraction. In this case, patterns become a kludge that gives the language much-needed super-abilities.
#### Inefficient solutions
Patterns try to systematize approaches that are already widely used. This unification is viewed by many as a dogma, and they implement patterns "to the letter", without adapting them to the context of their project.
#### Unjustified use
	"If all you have is a hammer, everything looks like a nail."
This is the problem that haunts many novices who have just familiarized themselves with patterns.

### Classification of patterns
Design patterns differ by their **complexity**, **level of detail** and **scale of applicability** to the entire system being designed.
The most basic and low-level patterns are often called *idioms*. They usually apply only to a single programming language.
The most universal and high-level patterns are *architectural patterns*. Developers can implement these patterns in virtually any language. Unlike other patterns, they can used to design the architecture of an entire application.
* **Creational Patterns** provide object creation mechanisms that increase flexibility and reuse of existing code.
* **Structural Patterns** explain how to assemble objects and classes into larger structures, while keeping these structures flexible and efficient.
* **Behavioral Patterns** take care of effective communication and the assignment of responsibilities between objects.