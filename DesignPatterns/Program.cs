public abstract class Animal
{
    public abstract void Speak();
}

public class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Woof!");
    }
}

public class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("Meow!");
    }
}

public class AnimalFactory
{
    public static Animal CreateAnimal(string type)
    {
        if (type == "Dog")
        {
            return new Dog();
        }
        else if (type == "Cat")
        {
            return new Cat();
        }
        else
        {
            throw new ArgumentException("Invalid animal type");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Animal dog = AnimalFactory.CreateAnimal("Dog");
        dog.Speak(); // Outputs: Woof!

        Animal cat = AnimalFactory.CreateAnimal("Cat");
        cat.Speak(); // Outputs: Meow!
    }
}

// The above code demonstrates the Factory Design Pattern by creating a factory class (AnimalFactory) that encapsulates the logic of instantiating different types of Animal objects based on input parameters.

public interface IObserver
{
    void Update(string message);
}

public class ConcreteObserver : IObserver
{
    private string name;

    public ConcreteObserver(string name)
    {
        this.name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{name} received message: {message}");
    }
}

public class Subject
{
    private List<IObserver> observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }
}

public class Program1
{
    public static void Main()
    {
        Subject subject = new Subject();

        IObserver observer1 = new ConcreteObserver("Observer 1");
        IObserver observer2 = new ConcreteObserver("Observer 2");

        subject.Attach(observer1);
        subject.Attach(observer2);

        subject.Notify("Hello, Observers!"); // Outputs: "Observer 1 received message: Hello, Observers!"
                                            //          "Observer 2 received message: Hello, Observers!"
    }
}

// The above code demonstrates the Observer Design Pattern by creating a Subject class that maintains a list of observers and notifies them of any state changes.

