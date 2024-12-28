namespace c_sharp_course.Classes;

public class ClassExample
{
    public class Person
    {
        public string name;
        public int age;

        public Person()
        {
        }

        public Person(string name)
        {
            this.name = name;
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        
        public void DisplayPersonDetails()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }

    public static void GenerateClasses()
    {
        Person person1 = new Person();
        Person person2 = new Person("John");
        Person person3 = new Person("Jane", 25);

        Console.WriteLine($"person3 name: {person3.name}, age: {person3.age}");
        person3.DisplayPersonDetails();
        // Console.WriteLine(ReturnDetails(person3.name, person3.age));
        // Console.WriteLine(ReturnDetails(person3));
    }

    /*public static string ReturnDetails(string name, int age)
    {
        return $"Name: {name}, Age: {age}";
    }*/
    
    // public static string ReturnDetails(Person person)
    // {
    //     return $"Name: {person.name}, Age: {person.age}";
    // }
}