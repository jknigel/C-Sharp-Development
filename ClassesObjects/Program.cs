public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person("Alice", 30);
        Person friend = new Person("Bob", 25);
        Person colleague = new Person("Charlie", 28);

        person.Greet();
        friend.Greet();
        colleague.Greet();
    }
}

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}