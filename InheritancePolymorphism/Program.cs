public static class Program
{
    public static void Main()
    {
        List<Animal> animals = new List<Animal>
        {
            new Dog(),
            new Cat()
        };

        foreach (Animal animal in animals)
        {
            animal.MakeSound();
            animal.Eat();
        }
    }
}

public interface IAnimal
{
    void Eat();
}

public class Animal : IAnimal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }

    public virtual void Eat()
    {
        Console.WriteLine("The animal is eating.");
    }
}

public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }

    public override void Eat()
    {
        Console.WriteLine("The dog is eating.");
    }
}

public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("The cat meows.");
    }

    public override void Eat()
    {
        Console.WriteLine("The cat is eating.");
    }
}
