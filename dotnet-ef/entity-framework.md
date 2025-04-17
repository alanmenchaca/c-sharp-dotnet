## Entity Framework
Entity Framework es la forma moderna de **conectar una Base de Datos** a una **aplicación .NET** usando la librería **ADO.NET**
* **ORM** de código abierto para .NET
* Utiliza ADO.NET para facilitar la **conexión a bases de datos**  y la **manipulación de datos**
* EF es compatible con: SQL Server, Azure SQL Database, SQLite, Azure Cosmos DB, MySQL, PostgresSQL, y otras bases de datos utilizando una API plugin.

### Ventajas de Entity Framework
* Mejora la velocidad de desarrollo
* Permite manejar un solo repositorio para backend y base de datos
* Mejora la seguridad
* Permite programar de manera más amigable y fácil
* Nos permite controlar el historial de cambios de la base de datos de manera muy sencilla
  
**ADO.NET:** Conjunto de librerías para acceder a datos y servicios de datos.  
  
### ¿Qué es un ORM?
**ORM (Object-Relational Mapping)** es una herramienta que realiza un mapeo que nos permite **transformar los objetos de la base de datos** como tablas y esquemas a **clases con atributos en código de programación** para poder manipular la información de una forma más fácil sin requerir SQL.
* Modelado de bases de datos relacional usando programación orientada a objetos
* Reemplaza a SQL como lenguaje de consultas utilizando funciones
  
### DESAFÍOS EN LA CONEXIÓN A UNA BASE DE DATOS:
* Mantenimiento del esquema.
* Creación de consultas usando SQL.
* Transformación de datos para poder ser usados en el backend.
* Garantizar la seguridad al manipular datos.  
  
### Fluent API
Es una forma avanzada de **configurar los modelos de Entity Framework** sin utilizar atributos o data-annotations, permitiendo diseñar la base de datos considerando **aspectos avanzados.** 
Se usan funciones de extensión anidadas para configurar tablas, columnas y especificar el mapeo de los datos.

## Migraciones
Es una funcionalidad de Entity Framework que nos permite **guardar de manera incremental los cambios realizados en la base de datos**. Nos permite **construir un versionamiento de la base de datos**.

### Comandos Basicos
* `dotnet ef migrations add InitialCreate : Crea una migración inicial.`
* `dotnet ef migrations add MyMigration : Crea una migración con nombre.`
* `dotnet ef database update : Actualiza la base de datos con las migraciones.`

`dotnet tool install --global dotnet-ef`
`dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.0`
