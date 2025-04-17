namespace c_sharp_course.Classes;

public class ClassFields
{
    public class Person
    {
        private string? _name;
        private int _age;

        public Person(string name, int age)
        {
            this._name = name;
            this._age = age;
        }

        public string? GetName() { return _name; }

        public void SetName(string name)
        {
            this._name = !string.IsNullOrEmpty(name) ? name : string.Empty;
        }

        public int GetAge() { return _age; }

        public void SetAge(int age)
        {
            this._age = age is > 0 and < 150 ? age : -1;
        }

        public string ReturnDetails()
        {
            return $"Name: {_name}, Age: {_age}";
        }
    }

    public static void ClassesWithFields()
    {
        Person person1 = new Person("John Doe", 42);
        Console.WriteLine($"{person1.ReturnDetails()}");
        Console.WriteLine($"Your name is: {person1.GetName()} and your age is {person1.GetAge()}\n");

        person1.SetName("");
        person1.SetAge(200);
        Console.WriteLine(person1.ReturnDetails());
    }
}