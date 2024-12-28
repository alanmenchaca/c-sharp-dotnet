namespace c_sharp_course.Classes;

public class ClassToString
{
    public class Person
    {
        private string? _name;
        private int _age;

        public string? Name
        {
            get => _name;
            set => this._name = !string.IsNullOrEmpty(value) ? value : string.Empty;
        }

        public int Age
        {
            get => _age;
            set => this._age = value is > 0 and < 150 ? value : -1;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        /*public string ReturnDetails()
        {
            return $"Name: {Name}, Age: {Age}";
        }*/

        public override bool Equals(object? obj)
        {
            Person? person = obj as Person;
            return Name != null && Name.Equals(person?.Name);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }
    }

    public static void ClassesWithToString()
    {
        Person person = new Person("John", 42);
        // Console.WriteLine(person.ReturnDetails());
        // Console.WriteLine(person.ToString());
        Console.WriteLine(person);

        Person p1 = new Person("Jane", 24);
        Person p2 = new Person("Jane", 24);

        if (p1.Equals(p2))
        {
            Console.WriteLine("The two objects are equal.");
        }
        else
        {
            Console.WriteLine("The two objects are not equal.");
        }
    }
}