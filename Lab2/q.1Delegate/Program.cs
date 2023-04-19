using System;

namespace DelegateAddition
{
    delegate int AddDelegate(int a, int b);

    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int firstDigit = 5;
            int secondDigit = 7;

            AddDelegate addDelegate = new AddDelegate(Add);

            int result = addDelegate(firstDigit, secondDigit);

            Console.WriteLine($"The sum of {firstDigit} and {secondDigit} is {result}.");
        }
    }
}
