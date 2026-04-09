using System;
using System.Collections.Generic;
using System.Text;

namespace Ice_Task_4
{
    public class RegistrationManager<T> where T : Registration
    {
        private List<T> registrations = new List<T>();

        // Add registration
        public void AddRegistration(T registration)
        {
            registrations.Add(registration);
        }

        // Display all
        public void DisplayAll()
        {
            Console.WriteLine("\n--- All Registrations ---");
            foreach (var reg in registrations)
            {
                reg.Display();
            }
        }

        // Display using delegate rule
        public void DisplayByCriteria(RegistrationCriteria criteria)
        {
            Console.WriteLine("\n--- Filtered Registrations ---");
            foreach (var reg in registrations)
            {
                if (criteria(reg))
                {
                    reg.Display();
                }
            }
        }

        // Total fees
        public double CalculateTotalFees()
        {
            double total = 0;
            foreach (var reg in registrations)
            {
                total += reg.RegistrationFee;
            }
            return total;
        }

        // Count approvals
        public int CountRequiringApproval()
        {
            int count = 0;
            foreach (var reg in registrations)
            {
                if (reg.RequiresApproval())
                {
                    count++;
                }
            }
            return count;
        }
    }
}