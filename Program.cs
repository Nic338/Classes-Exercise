using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime aDate = DateTime.Now;
            // Create an instance of a company. Name it whatever you like.
            Company company = new Company("Made Up Enterprises", aDate);
            // Create three employees
            Employee firstEmployee = new Employee("Darrel","Hoovawitz","CFO", aDate);
            Employee secondEmployee = new Employee("Maxine","Crabtree","Leader of the Free World", aDate);
            Employee thirdEmployee = new Employee("Kim","KarDAHSHIUN","Leader of Jumpscares", aDate);
            // Assign the employees to the company
            company.Employees.Add(firstEmployee);
            company.Employees.Add(secondEmployee);
            company.Employees.Add(thirdEmployee);
            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            company.ListEmployees();
        }
    }
}
