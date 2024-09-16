//1
using System;

namespace Employee
{
    class Employee
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public decimal Salary { get; set; }


        public Employee(string name, string email, decimal salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }


        public void DisplayEmployeeInfo()
        {
            Console.WriteLine("Employee Details:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Salary: {Salary:C}");
        }

        class Program
        {
            /*static void Main(string[] args)
            {
                // Create Employee object
                Employee emp = new Employee("Akshata Nepal", "akshata@example.com", 55000);

                // Display employee details
                emp.DisplayEmployeeInfo();
                Console.ReadKey();
            }*/
        }
        
    }
}
