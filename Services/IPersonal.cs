using System;
using System.Collections.Generic;
using BudgetTracker.Models;

namespace BudgetTracker.Services
{
    public interface IPersonal
    {
        void AddIncome(decimal amount, DateTime date, string description, decimal initialBalance);
        void AddExpence(string name, decimal amount, DateTime date, string description, decimal initialBalance);
        void DisplayDetails(string name, decimal amount, DateTime date, string description, decimal initialBalance);

        decimal GetTotalIncome();
        decimal GetTotalExpenses();
        decimal GetCurrentBalance();
        List<Income> GetRecentIncomes(int count);
        List<Expense> GetRecentExpenses(int count);
        
    }
}