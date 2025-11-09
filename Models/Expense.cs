using System;

namespace BudgetTracker.Models
{
    public class Expense
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public decimal Balance { get; set; }

        public Expense(string name, decimal amount, DateTime date, string description, decimal initialBalance = 0)
        {
            Name = name;
            Amount = amount;
            Date = date;
            Description = description;
            Balance = initialBalance;
        }
    }
}