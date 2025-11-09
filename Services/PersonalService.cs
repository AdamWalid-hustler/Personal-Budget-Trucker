using System;
using BudgetTracker.Models;

namespace BudgetTracker.Services
{
    public class PersonalService : IPersonal
    {
        private readonly List<Income> _incomes = new List<Income>();
        private readonly List<Expense> _expenses = new List<Expense>();

        public void AddIncome(decimal amount, DateTime date, string description, decimal initialBalance)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException("Amount connot be zero", nameof(amount));
            _incomes.Add(new Income(amount, date, description, initialBalance));
        }

        public void AddExpence(string name, decimal amount, DateTime date, string description, decimal initialBalance)
        {
            if (amount >= 0)
                throw new ArgumentOutOfRangeException("Amount cannot be zero", nameof(amount));
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
                throw new ArgumentNullException("Name or description cannot be empty.");
        }
    }
}