namespace c_sharp_course;

public class Structures
{
    struct Person
    {
        public string? name;
        public int age;
        public int birthYear;

        public Person(string? name, int age, int birthYear)
        {
            this.name = name;
            this.age = age;
            this.birthYear = birthYear;
        }
    }

    public static void ShowStructures()
    {
        // Person person = new Person();
        // person.name = "John";
        // person.age = 42;

        Person person = ReturnPerson();
        Console.WriteLine($"Name: {person.name}, Age: {person.age}, Birth Year: {person.birthYear}");
    }

    private static Person ReturnPerson()
    {
        Console.Write("Enter your name: ");
        string? name = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter your birth year: ");
        int birthYear = Convert.ToInt32(Console.ReadLine());

        return new Person(name, age, birthYear);
    }
}