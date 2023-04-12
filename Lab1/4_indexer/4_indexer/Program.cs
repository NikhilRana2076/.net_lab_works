using System;

public class Student
{
    private string[] names = new string[10];

    // Indexer to get or set student names
    public string this[int index]
    {
        get
        {
            return names[index];
        }
        set
        {
            names[index] = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student student = new Student();

        // Setting names using indexer
        student[0] = "Nikhil";
        student[1] = "Prakash";
        student[2] = "Rochak";
        student[3] = "Roshan";
        student[4] = "Suzan";
        student[5] = "Ashmin";
        student[6] = "Thaneswor";
        student[7] = "Sandesh";
        student[8] = "David";
        student[9] = "Saurab";

        // Retrieving names using indexer and displaying them
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Student {0}: {1}", i + 1, student[i]);
        }

        Console.ReadKey();
    }
}
