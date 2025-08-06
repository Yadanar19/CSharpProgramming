using System;

namespace Starter
{
    class Program
    {
        static void Main()
        {
            // Create Fashion department object and display promotions
            Fashion fashionDepartment = new Fashion();
            fashionDepartment.DisplayPromotions();

            Console.ReadLine(); // Wait for user input before closing
        }
    }

    // Stores sale event data.
    class Promotion
    {
        public string Name { get; private set; }
        public DateTime Start { get; private set; }
        public DateTime End { get; private set; }

        // Constructor to initialize promotion details
        public Promotion(DateTime start, DateTime end, string name)
        {
            Start = start;
            End = end;
            Name = name;
        }
    }

    // Abstract class that stores and displays promotional information.
    abstract class Department
    {
        protected Promotion[] sales;

        // property for department name
        public string DepartmentName { get; protected set; }

        // Abstract method to assign promotions
        protected abstract void AssignPromotions();

        // Constructor to initialize department name
        protected Department(string departmentName)
        {
            // Check if the departmentName is null or empty
            if (string.IsNullOrEmpty(departmentName))
            {
                throw new ArgumentNullException(nameof(departmentName), "Department name cannot be null or empty");
            }

            DepartmentName = departmentName;
        }

        // Virtual method to display promotions
        public virtual void DisplayPromotions()
        {
            Console.WriteLine("Department Promotions: " + DepartmentName);
            foreach (Promotion sale in sales)
            {
                Console.WriteLine("Name: " + sale.Name);
                Console.WriteLine("Start: " + sale.Start.ToString("M"));
                Console.WriteLine("End: " + sale.End.ToString("M"));
                Console.WriteLine(); // New line between promotions
            }
        }
    }

    // Implementing class that sets department name and assigns promotions
    class Fashion : Department
    {
        // Constructor to initialize the department name and assign promotions
        public Fashion() : base("Fashion")  // Pass department name to the base class constructor
        {
            AssignPromotions(); // Assign promotions for the department
        }

        // Assign promotions for the Fashion department
        protected override void AssignPromotions()
        {
            sales = new Promotion[]
            {
                new Promotion(new DateTime(2024, 9, 1), new DateTime(2024, 9, 15), "Fall Sale"),
                new Promotion(new DateTime(2024, 11, 20), new DateTime(2024, 11, 30), "Black Friday Deals"),
                new Promotion(new DateTime(2024, 12, 10), new DateTime(2024, 12, 24), "Holiday Clearance")
            };
        }
    }
}
