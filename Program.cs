public abstract class Animal
{
    protected string name { get; set; }
    public Animal(string name)
    {
        this.name = name;
    }

    public abstract void Eat();
    public abstract void Sleep();

    public string WhatName()
    {
        return name;
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override void Eat()
    {
        Console.WriteLine("The cat eats the food!");
    }

    public override void Sleep()
    {
        Console.WriteLine("The cat sleeps a loot!");
    }
}

public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override void Eat()
    {
        Console.WriteLine("The dog eats a loot!");
    }

    public override void Sleep()
    {
        Console.WriteLine("The dog sleeps in your house!");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Animal dog = new Dog("Rex");
        Animal cat = new Cat("Felix");

        dog.Eat();
        dog.Sleep();
        Console.WriteLine();

        cat.Eat();
        cat.Sleep();

        Console.WriteLine($"\nThe name of the dog is {dog.WhatName()} and the cat is {cat.WhatName()}!");
    }
}