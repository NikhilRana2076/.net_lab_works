using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = { 1, 2, 3, 4, 5 };

        Console.Write("Original array: ");
        PrintArray(arr);

        ReverseArray(arr);

        Console.Write("Reversed array: ");
        PrintArray(arr);

        Console.ReadKey();
    }

    static void ReverseArray(int[] arr)
    {
        int i = 0;
        int j = arr.Length - 1;

        while (i < j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;

            i++;
            j--;
        }
    }

    static void PrintArray(int[] arr)
    {
        foreach (int item in arr)
        {
            Console.Write("{0} ", item);
        }
        Console.WriteLine();
    }
}
