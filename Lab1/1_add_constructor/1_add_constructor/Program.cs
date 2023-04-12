using System;

public class Adder
{
    private int num1, num2;

    // Constructor to initialize the two numbers
    public Adder(int n1, int n2)
    {
        num1 = n1;
        num2 = n2;
    }

    // Method to add the two numbers
    public int Add()
    {
        return num1 + num2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first digit: ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second digit: ");
        int n2 = int.Parse(Console.ReadLine());

        // Creating an object of Adder class and passing two digits as constructor arguments
        Adder adder = new Adder(n1, n2);

        // Calling Add method to get the sum
        int sum = adder.Add();

        Console.WriteLine("The sum of {0} and {1} is {2}", n1, n2, sum);
        Console.ReadKey();
    }
}

