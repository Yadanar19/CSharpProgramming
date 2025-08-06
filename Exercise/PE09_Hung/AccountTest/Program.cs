using System;

namespace AccountTest
{
    class Program
    {
        public static void Main()
        {
            const decimal OPENING_BALANCE = 55m;
            const decimal MONTHLY_INTEREST = 0.0033m;

            // Create and use Savings object
            Savings savings = new Savings(OPENING_BALANCE);
            savings.AddMonthlyInterest(MONTHLY_INTEREST);
            savings.ShowBalance();

            // Create and use Checking object
            Checking checking = new Checking(OPENING_BALANCE);
            checking.DeductServiceCharge();
            checking.ShowBalance();

            // Create and use JointSaving object
            JointSaving jointSaving = new JointSaving(OPENING_BALANCE, "Alice & Bob");
            jointSaving.AddMonthlyInterest(MONTHLY_INTEREST);
            jointSaving.ShowBalance();
            jointSaving.ShowOwners();

            Console.ReadLine();  // Wait for user input before closing
        }
    }

    // Base class Account
    class Account
    {
        protected decimal BankBalance { get; set; }

        // Constructor
        protected Account()
        {
            Console.WriteLine("Inside the Account constructor.");
        }

        // Method to show the balance
        public void ShowBalance()
        {
            Console.WriteLine("The Balance is: " + BankBalance.ToString("C"));
        }
    }

    // Derived class Savings
    class Savings : Account
    {
        // Constructor
        public Savings(decimal balance)
        {
            Console.WriteLine("Inside the Savings constructor.");
            BankBalance = balance;
        }

        // Custom method to add monthly interest
        public void AddMonthlyInterest(decimal interest)
        {
            BankBalance *= (1.0m + interest);
        }
    }

    // Derived class Checking
    class Checking : Account
    {
        // Constructor
        public Checking(decimal balance)
        {
            Console.WriteLine("Inside the Checking constructor.");
            BankBalance = balance;
        }

        // Custom method to deduct service charge
        public void DeductServiceCharge()
        {
            const decimal CHECKING_FEE = 1.50m;
            BankBalance -= CHECKING_FEE;
        }
    }

    // New derived class JointSaving
    class JointSaving : Savings
    {
        private string Owners { get; set; }

        // Constructor
        public JointSaving(decimal balance, string owners) : base(balance)
        {
            Console.WriteLine("Inside the JointSaving constructor.");
            Owners = owners;
        }

        // Method to show the account owners
        public void ShowOwners()
        {
            Console.WriteLine("Joint account owners: " + Owners);
        }
    }
}
