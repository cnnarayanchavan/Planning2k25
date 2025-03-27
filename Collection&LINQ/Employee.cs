using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_LINQ
{
    internal class Employee
    {
        public int EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public string? Gender { get; set; }
        public string? Department { get; set; }
        public decimal Salary { get; set; }

        //Method  for displaying these values

        public void Display()
        {
            Console.WriteLine($"🆔 Employee ID: {EmployeeID}");
            Console.WriteLine($"👤 Name: {EmployeeName}");
            Console.WriteLine($"🚻 Gender: {Gender}");
            Console.WriteLine($"🏢 Department: {Department}");
            Console.WriteLine($"💰 Salary: {Salary:C}"); // ":C" formats salary as currency
            Console.WriteLine("———————————————————————");
        }

    }
}
