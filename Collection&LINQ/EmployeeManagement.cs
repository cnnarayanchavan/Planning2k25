using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Collection_LINQ
{
    internal class EmployeeManagement
    {
        //we are going to store data into Dictionary for storing employee data
        public static Dictionary<int, Employee> EmpDict = new Dictionary<int, Employee>();


        //first method to add employee data
        public static int EmployeeIDCounter = 1;  // Initialize the counter

        public static void AddEmployee(Employee employee)
        {
            employee.EmployeeID = EmployeeIDCounter++;  // Assign and increment the ID
            EmpDict.Add(employee.EmployeeID, employee);

            Console.WriteLine($"✅ Employee {employee.EmployeeName} added successfully with ID: {employee.EmployeeID}");
        }



        //second method to view employee data
        public static void ViewEmployee()
        {
            if (EmpDict.Count == 0) 
            {    
                Console.WriteLine("No record found..");
            }
            else
            {
                Console.WriteLine("Employee List.");
                foreach (var emp in EmpDict.Values)
                {
                    emp.Display();
                }
            }
        }

        //third method to delete eployee
        public static void DeleteEmployee(int ID)
        {
            EmpDict.Remove(ID);
            Console.WriteLine("Employee Deleted Successfully.");
        }

        //fourth method to update employee data
        public static void UpdateEmployee(int ID)
        {
            if (EmpDict.ContainsKey(ID))
            {
                var Emp = EmpDict[ID];

                Console.Write("Enter new name: ");
                Emp.EmployeeName = Console.ReadLine();

                Console.Write("Update gender: ");
                Emp.Gender = Console.ReadLine();

                Console.Write("Enter new department: ");
                Emp.Department = Console.ReadLine();

                Console.Write("Enter new salary: ");
                Emp.Salary = decimal.Parse(Console.ReadLine());

                EmpDict[ID] = Emp;

                Console.WriteLine("✅ Employee Updated Successfully!");
            }
            else
            {
                Console.WriteLine("❌ Employee Not Found!"); 
            }
        }

        //Fifth method to SORT employee by salary 
        public static void SortEmployeesBySalary()
        {
            if (EmpDict.Count == 0)
            {
                Console.WriteLine("No employees to sort.");
                return;
            }

            var sortedEmployees = EmpDict.Values.OrderBy(emp => emp.Salary).ToList();

            Console.WriteLine("📊 Employees Sorted by Salary (Ascending Order):");
            foreach (var emp in sortedEmployees)
            {
                emp.Display();
            }
        }

        //sixth function for fetching employee data by Department
        public static void GetEmployeesByDepartment(string department)
        {
            var result = EmpDict.Values.Where(emp => emp.Department == department);

            if (!result.Any())
                Console.WriteLine($"❌ No employees found in '{department}' department.");
            else
            {
                Console.WriteLine($"\n🏢 Employees in {department} Department:");
                foreach (var emp in result)
                {
                    emp.Display();
                }
            }
        }


    }
}
