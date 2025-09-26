using System;

class Program
{
    static void Main(string[] args)
    {
        // Probar la clase base
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());
        Console.WriteLine();

        // Probar MathAssignment
        MathAssignment m1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(m1.GetSummary());  // Método heredado
        Console.WriteLine(m1.GetHomeworkList());  // Método propio
        Console.WriteLine();

        // Probar WritingAssignment  
        WritingAssignment w1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(w1.GetSummary());  // Método heredado
        Console.WriteLine(w1.GetWritingInformation());  // Método propio
    }
}