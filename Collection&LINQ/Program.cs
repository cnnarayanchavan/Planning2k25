using System;
using Collection_LINQ;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("\n \U0001F680 Employee Management System \U0001F680");
        Console.WriteLine();
        bool Check = true;

        while (Check)
        {

            Console.WriteLine(" \nMenu");
            Console.WriteLine("1. Add Employee");
            Console.WriteLine("2. View Employees");
            Console.WriteLine("3. Delete Employee");
            Console.WriteLine("4. Update Employee");
            Console.WriteLine("5. Sort Employee By Salary");
            Console.WriteLine("6. Get Employee By Department");
            Console.WriteLine("7. Exit");
            Console.Write("Enter Choice: ");
            int Choice = int.Parse(Console.ReadLine());
            Console.WriteLine();
            switch (Choice)
            { 
                case 1:
                    Employee employee = new Employee();
                    Console.Write("Enter Employee Name: ");
                    employee.EmployeeName = Console.ReadLine();

                    Console.Write("Enter Employee Gender: ");
                    employee.Gender = Console.ReadLine();

                    Console.Write("Enter Employee Department: ");
                    employee.Department = Console.ReadLine();

                    Console.Write("Employee Salary: ");
                    employee.Salary = decimal.Parse(Console.ReadLine());

                    //Add employee data to dictionary
                    EmployeeManagement.AddEmployee(employee);
                    //Check = false;
                    break;

                case 2:
                    EmployeeManagement.ViewEmployee();
                    break;

                case 3:
                    Console.Write("Enter Employee ID to Delete:");
                    int Did = int.Parse(Console.ReadLine());
                    EmployeeManagement.DeleteEmployee(Did);
                    break;

                case 4:
                    Console.Write("Enter Employee ID to Update:");
                    int Uid = int.Parse(Console.ReadLine());
                    EmployeeManagement.UpdateEmployee(Uid);
                    break;

                case 5:
                    EmployeeManagement.SortEmployeesBySalary();
                    break;

                case 6:
                    Console.Write("Enter Department Name: ");
                    string dept = Console.ReadLine();
                    EmployeeManagement.GetEmployeesByDepartment(dept);
                    break;

                case 7:
                    Check = false;
                    // "\U0001F44B"  use this unicode to have waving hand emoji
                    Console.WriteLine("👋 Thank you for using the application. Exiting now...");
                    break;

                default:
                    Console.WriteLine("❌ Invalid Option!");
                    break;
            }
        }

    }

}
