**Prototype** is a creational design pattern that lets you copy existing objects without making your code dependent on their classes.

### Problem
Say you have an object, and you want to create an **exact copy** of it. How would you do it?
First, you have to create a new object of the same class. Then you have to go through all the fields of the original object and copy their values over to the new object.
But there are some problems:
* Some of the object's fields **may be private** and **not visible** from outside of the object.
* Since you **have to know the object's class** to create a duplicate, your code becomes **dependent** on that class.
* Sometimes you **only know the interface** that the object follows, but not its **concrete class**, when, for example, a parameter in a method accepts any objects that follow some interface.

### Solution
The Prototype pattern delegates the **cloning process** to the **actual objects** that are being cloned. The pattern declares a common interface for all objects that support cloning. This interface lets you clone an object without coupling your code to the class of that object.
Usually, such an interface contains just a single `clone` method.
An object that supports cloning is called a `prototype`. When you need an object like the one you've configured, you just clone a prototype instead of constructing a new object from scratch.

![[prototype-structure.png]]

### Applicability
 * Use the Prototype pattern when your code **shouldn't depend** on the concrete classes of objects that you need to copy.
	 * The prototype pattern provides the client code with a general interface for working with all objects that support cloning. This interface makes the client code independent from the concrete class of objects that it clones.
 * Use the pattern when  you want to **reduce** the number of subclasses that only differ in the way they initialize their respective objects.
	 * The prototype pattern lets you use a set of pre-built objects configured in various ways as prototypes. Instead of **instantiating a subclass** that matches some configuration, the client can simply look for an appropriate prototype and clone it.

### How to Implement
1. Create the prototype interface and declare the `clone` method in it.
2. A prototype class must define the alternative constructor that accepts an object of that class as an argument. The constructor must copy the values of all fields defined in the class from the passed object into the newly created instance.
3. The cloning methods usually consists of just one line: running a `new` operator with the prototypical version of the constructor. Every class must explicitly override the cloning method and use its own class name along with the `new` operator. Otherwise, the cloning method may produce an object of a parent class.