using System;
using System.Collections.Generic;
using System.Text;

namespace Ice_Task_4
{
    public class Registration
    {
        public string EmployeeName { get; set; }
        public string EventName { get; set; }
        public string Department { get; set; }
        public double RegistrationFee { get; set; }
        public int NumberOfDays { get; set; }

        // Capture user input
        public void CaptureDetails()
        {
            Console.Write("Enter Employee Name: ");
            EmployeeName = Console.ReadLine();

            Console.Write("Enter Event Name: ");
            EventName = Console.ReadLine();

            Console.Write("Enter Department: ");
            Department = Console.ReadLine();

            Console.Write("Enter Registration Fee: ");
            RegistrationFee = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Number of Days Attending: ");
            NumberOfDays = Convert.ToInt32(Console.ReadLine());
        }

        // Display details
        public void Display()
        {
            Console.WriteLine($"Employee: {EmployeeName}, Event: {EventName}, Dept: {Department}, Fee: R{RegistrationFee}, Days: {NumberOfDays}");
        }

        // Check if approval is needed
        public bool RequiresApproval()
        {
            return RegistrationFee > 2000 || NumberOfDays > 3;
        }
    }
}