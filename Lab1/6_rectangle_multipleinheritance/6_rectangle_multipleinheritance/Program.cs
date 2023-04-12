using System;

// First interface for length property
interface ILength
{
    int Length { get; set; }
}

// Second interface for width property
interface IWidth
{
    int Width { get; set; }
}

// Third interface for area property
interface IArea : ILength, IWidth
{
    int Area { get; }
}

// Rectangle class implementing all three interfaces
class Rectangle : IArea
{
    public int Length { get; set; }
    public int Width { get; set; }

    public int Area
    {
        get { return Length * Width; }
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        rect.Length = 5;
        rect.Width = 10;

        Console.WriteLine("Length: {0}", rect.Length);
        Console.WriteLine("Width: {0}", rect.Width);
        Console.WriteLine("Area: {0}", rect.Area);

        Console.ReadKey();
    }
}
