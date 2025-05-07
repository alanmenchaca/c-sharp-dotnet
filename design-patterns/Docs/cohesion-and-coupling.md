### _High Cohesion – Single Responsibility_
**High cohesion** means that a component **does one thing well** and has a **clear purpose and scope**.  
**Low cohesion** means that a component **does many things poorly** and has a **vague or overlapping role and scope**.

If high cohesion is lacking, consider splitting the class (or package, or deployment unit):
- One single responsibility
- One reason to change
- Class attributes should depend on its methods
- Class methods should depend on its attributes

**Single Responsibility Principle (SRP) → High Cohesion**

### _Low Coupling_
Coupling refers to the degree and type of **interdependence between software modules**.  
It measures how **closely connected** two routines or modules are and how **strongly one depends on the other**.
**Low coupling** typically **correlates** with high cohesion — and vice versa.
* **Target Scenario:** Low Coupling and High Cohesion
