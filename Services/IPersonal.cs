using System;

namespace BudgetTracker.Services
{
    public interface IPersonal
    {
        void AddIncome(decimal amount, DateTime date, string description, decimal initialBalance);
        void AddExpence(string name, decimal amount, string description);
        void DisplayDetails(string name, decimal amount, string description, DateTime date);
        
    }
}