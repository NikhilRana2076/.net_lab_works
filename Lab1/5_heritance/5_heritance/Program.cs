using System;

// Single inheritance
class Vehicle
{
    public virtual void Drive()
    {
        Console.WriteLine("Driving a vehicle");
    }
}

class Car : Vehicle
{
    public override void Drive()
    {
        Console.WriteLine("Driving a car");
    }
}

// Multiple inheritance
interface IAnimal
{
    void Eat();
}

interface IMammal
{
    void Nurse();
}

class Platypus : IAnimal, IMammal
{
    public void Eat()
    {
        Console.WriteLine("Eating insects and worms");
    }

    public void Nurse()
    {
        Console.WriteLine("Nursing young with milk");
    }
}

// Multilevel inheritance
class Animal
{
    public virtual void Move()
    {
        Console.WriteLine("Moving");
    }
}

class Mammal : Animal
{
    public override void Move()
    {
        Console.WriteLine("Moving on four legs");
    }
}

class Cat : Mammal
{
    public override void Move()
    {
        Console.WriteLine("Moving like a cat");
    }
}

// Hierarchical inheritance
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle");
    }
}

class Square : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a square");
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Single inheritance
        Vehicle vehicle = new Vehicle();
        Car car = new Car();

        vehicle.Drive();
        car.Drive();

        Console.WriteLine();

        // Multiple inheritance
        Platypus platypus = new Platypus();
        platypus.Eat();
        platypus.Nurse();

        Console.WriteLine();

        // Multilevel inheritance
        Animal animal = new Animal();
        Mammal mammal = new Mammal();
        Cat cat = new Cat();

        animal.Move();
        mammal.Move();
        cat.Move();

        Console.WriteLine();

        // Hierarchical inheritance
        Shape circle = new Circle();
        Shape square = new Square();

        circle.Draw();
        square.Draw();

        Console.ReadKey();
    }
}

