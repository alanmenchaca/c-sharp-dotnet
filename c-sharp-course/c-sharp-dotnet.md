## What is C#?
* It is an **object-oriented programming language** created by Microsoft that runs on the .NET Framework.
* C# has roots from the C family, and the language is close to other popular languages like C++ and Java.

### Why use C#?
* It is one of the most popular programming languages in the world!
* It is simple to learn and simple to use.
* C# is an object-oriented language which gives a clear structure to program and allows code to be reused, lowering development costs.
* As C# is close to C, C++ and Java, it makes it easy for programmers to switch to C# or vice versa

## ¿Qué es .NET?
.NET (dot net) es una plataforma de **desarrollo de aplicaciones** creada por Microsoft, cuando se habla de .NET se habla de un **conjunto de librerías** que nos va a permitir desarrollar aplicaciones para diferentes plataformas.
Fue creada para poder ofrecer a los desarrolladores la oportunidad de crear fácilmente aplicaciones de todo tipo utilizando un único **SDK**, es decir un único conjunto de librerías base para todas las posibles plataformas y posibles tipos de aplicaciones que existen en el mercado.

### Common Language Runtime CLR
* Transforma de **Common Intermediate Language** (CIL) o **MSIL** a código nativo
* Compilador en tiempo de ejecución.
* Agiliza la ejecución del código compilado.

### ¿Qué es el compilador Roslyn?
* Conocido como **.NET Compiler Platform**.
* Soporta C# y Visual Basic
* Analiza estilo y calidad de código usando niveles de severidad
* Rápido y ágil.

### Common Language Specification (CLS)
Es un conjunto de **reglas y métricas básicas** que necesitan seguir y cumplir los lenguajes compatibles con .NET para luego ser compilados (Roslyn) a otro lenguaje neutral intermedio llamado **CIL (Common Intermediate Language)** donde finalmente será traducido al **CLR (Common Language Runtime)** que dará como resultado un **lenguaje Assembly**, lenguaje máquina.
El CLS asegura la completa interoperabilidad entre las aplicaciones	independientemente 

### Common Type System
* Define los tipos generales que se usan dentro del lenguaje.
* Provee la librería base para los tipos primitivos (byte, char, int).
* Provee un modelo de tipos orientado a objetos.

### Archivo JSON Global
Es un archivo que nos permite administrar las **versiones de los SDK** que trabajamos en .NET:
* `dotnet new global json`

Siempre trae la version mas reciente pero podemos usar y forzar a alguna version que tengamos instalada. 
`allowPrerelease: false` habilita o deshabilita el uso de release beta o alpha o de prueba para evitar fallas de compilado.
