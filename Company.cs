using System;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees{ get; }

    // Create a constructor method that accepts two arguments:
    public Company(string name, DateTime date)
    {
    //     1. The name of the company
        Name = name;
    //     2. The date it was created
        CreatedOn = date;
        Employees = new List<Employee>();
    }
    // The constructor will set the value of the public properties
    public void ListEmployees()
    {
        foreach(Employee employee in Employees)
        {
            Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {Name} as {employee.Title} since {employee.StartDate}");
        }
    }
}
}