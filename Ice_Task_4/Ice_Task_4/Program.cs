namespace Ice_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrationManager<Registration> manager = new RegistrationManager<Registration>();

            Console.Write("How many registrations do you want to enter? ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"\n--- Registration {i + 1} ---");

                Registration reg = new Registration();
                reg.CaptureDetails();

                manager.AddRegistration(reg);
            }

            // Display all
            manager.DisplayAll();

            // Display those requiring approval
            Console.WriteLine("\n--- Registrations Requiring Approval ---");
            manager.DisplayByCriteria(r => r.RequiresApproval());

            // Ask for department
            Console.Write("\nWhich department would you like to view? ");
            string dept = Console.ReadLine();

            manager.DisplayByCriteria(r => r.Department.Equals(dept, StringComparison.OrdinalIgnoreCase));

            // Example: Discount rule (optional logic)
            Console.WriteLine("\n--- Registrations Eligible for Discount (Fee < R1000) ---");
            manager.DisplayByCriteria(r => r.RegistrationFee < 1000);

            // Total fees
            Console.WriteLine($"\nTotal Registration Fees: R{manager.CalculateTotalFees()}");

            // Count approvals
            Console.WriteLine($"Registrations requiring approval: {manager.CountRequiringApproval()}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}