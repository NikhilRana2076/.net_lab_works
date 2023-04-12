using System;

public class Student
{
    public int Id { get; set; }   // Automatic property for student ID
    public string Name { get; set; }   // Automatic property for student name
}

class Program
{
    static void Main(string[] args)
    {
        Student[] students = new Student[10];

        // Taking student ID and name as input and setting the values of the properties
        for (int i = 0; i < 10; i++)
        {
            students[i] = new Student();

            Console.WriteLine("Enter details for student {0}:", i + 1);

            Console.Write("Enter student ID: ");
            students[i].Id = int.Parse(Console.ReadLine());

            Console.Write("Enter student name: ");
            students[i].Name = Console.ReadLine();
        }

        // Displaying the student IDs and names using a loop
        Console.WriteLine("\nList of Students:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Student {0}: ID={1}, Name={2}", i + 1, students[i].Id, students[i].Name);
        }

        Console.ReadKey();
    }
}
