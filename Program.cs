<<<<<<< HEAD
using System;

// Define the Employee class
public class Employee
{
    // Properties for Employee class
    public int Id { get; set; }         // Unique identifier for the employee
    public string FirstName { get; set; } // First name of the employee
    public string LastName { get; set; }  // Last name of the employee

    // Overload the "==" operator to compare two Employee objects
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Check if both objects are the same instance
        if (ReferenceEquals(emp1, emp2))
        {
            return true; // They are the same
        }

        // Check if either object is null
        if (emp1 is null || emp2 is null)
        {
            return false; // One of them is null, hence not equal
        }

        // Compare the Ids of the employees
        return emp1.Id == emp2.Id; // They are equal if Ids match
    }

    // Overload the "!=" operator (must be implemented if "==" is overloaded)
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        return !(emp1 == emp2); // Return the opposite of the equality check
    }

    // Override the Equals method
    public override bool Equals(object obj)
    {
        // Check if the compared object is an Employee
        if (obj is Employee employee)
        {
            return this == employee; // Use the overloaded "==" operator
        }
        return false; // Not equal if not an Employee
    }

    // Override GetHashCode
    public override int GetHashCode()
    {
        return Id.GetHashCode(); // Use Id to generate a hash code
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create two Employee objects
        Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
        Employee emp2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" };
        Employee emp3 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" }; // Same Id as emp1

        // Compare the Employee objects using the overloaded operators
        Console.WriteLine($"emp1 == emp2: {emp1 == emp2}"); // Should be false
        Console.WriteLine($"emp1 == emp3: {emp1 == emp3}"); // Should be true

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}
=======
﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
>>>>>>> 6792422a0e68fa6598b77dc9f908d2674b8b928a
