using System;
using System.Linq;
using System.Collections.Generic;
using BudgetTracker.Models;

namespace BudgetTracker.Services
{
    public class PersonalService : IPersonal
    {
        private readonly List<Income> _incomes = new List<Income>();
        private readonly List<Expense> _expenses = new List<Expense>();
         private decimal balance = 0;

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

            _expenses.Add(new Expense(name, amount, date, description, initialBalance));
            if (amount <= initialBalance)
            {
                balance -= amount;
            }
        }

        public void DisplayDetails(string name, decimal amount, DateTime date, string description, decimal initialBalance)
        {
            Console.WriteLine($"{name}, cost {amount}, date {date}, description {description}, money left {initialBalance}");
        }

        public decimal GetTotalIncome()
        {
            return _incomes.Sum(i => i.Amount);
        }
        public decimal GetTotalExpenses()
        {
            return _expenses.Sum(e => e.Amount);
        }

        public decimal GetCurrentBalance()
        {
            return GetTotalIncome() - GetTotalExpenses();
        }

        public List<Income> GetRecentIncomes(int count)
        {
            return _incomes.OrderByDescending(i => i.Date).Take(count).ToList(); // Ensure the newest come first
        }

        public List<Expense> GetRecentExpenses(int count)
        {
            return _expenses.OrderByDescending(i => i.Date).Take(count).ToList();
        }

    }
}