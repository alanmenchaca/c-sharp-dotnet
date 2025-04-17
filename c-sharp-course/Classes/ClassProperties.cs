namespace c_sharp_course.Classes;

public class ClassProperties
{
    public class Person
    {
        private string? _name;
        private int _age;
        
        // public string? Name { get; set; };
        // public string? Age { get; set; };

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
            this._name = name;
            this._age = age;
        }

        public string ReturnDetails()
        {
            return $"Name: {this._name}, Age: {this._age}";
        }
    }

    public static void ClassesWithProperties()
    {
        Person person1 = new Person("John Doe", 42);
        Console.WriteLine(person1.ReturnDetails());
        Console.WriteLine($"Your name is {person1.Name} and your age is {person1.Age}");
    }
}