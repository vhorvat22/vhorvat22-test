using System;
using System.Collections.Generic;
using System.Linq;

// Transaction class represents a single financial transaction.
public class Transaction
{
    public decimal Amount { get; set; }
    public string Description { get; set; }

    public Transaction(decimal amount, string description)
    {
        Amount = amount;
        Description = description;
    }
}

// FinanceTrack class manages a list of transactions and provides functionality to add transactions and calculate balance.
public class FinanceTrack
{
    private List<Transaction> transactions = new List<Transaction>();

    public void AddTransaction(decimal amount, string description)
    {
        transactions.Add(new Transaction(amount, description));
    }

    public List<Transaction> ViewTransactions()
    {
        return transactions;
    }

    public decimal CalculateBalance()
    {
        return transactions.Sum(t => t.Amount);
    }
}

// Program class contains the main method to demonstrate the functionality of FinanceTrack class.
class Program
{
    static void Mein(string[] args)
    {
        FinanceTrack tracker = new FinanceTrack();

        // Example usage
        tracker.AddTransaction(1000, "Salary");
        tracker.AddTransaction(-100, "Groceries");
        tracker.AddTransaction(-50, "Electricity bill");

        Console.WriteLine("Transactions:");
        foreach (var transaction in tracker.ViewTransactions())
        {
            Console.WriteLine($"{transaction.Description}: {transaction.Amount:C}");
        }

        Console.WriteLine("Current Balance: " + tracker.CalculateBalance().ToString("C"));
    }
}
