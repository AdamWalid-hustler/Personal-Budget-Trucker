using System;

namespace BudgetTracker.Models
{
    public class Income
    {
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public decimal Balance { get; set; }

        public Income() { }

        public Income(decimal amount, DateTime date, string description, decimal initialBalance = 0)
        {
            Amount = amount;
            Date = date;
            Description = description;
            Balance = initialBalance;
        }
    }
}