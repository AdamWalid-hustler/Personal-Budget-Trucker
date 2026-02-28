# BudgetTracker

BudgetTracker is a simple Blazor WebAssembly application for tracking your personal income and expenses. It allows you to add, view, and manage your financial records in a user-friendly interface.

## Features
- Add and view incomes
- Add and view expenses
- View recent transactions
- Calculate total income, total expenses, and current balance

## Project Structure
- `Pages/` - Contains Blazor pages for Home, Income, and Expenses
- `Models/` - Data models for Income and Expense
- `Services/` - Service layer for managing personal finance data
- `Layout/` - Application layout and navigation components
- `wwwroot/` - Static files (CSS, sample data, etc.)

## Getting Started

### Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)

### Build and Run
1. Clone the repository or download the source code.
2. Open a terminal in the project directory.
3. Run the following command to build and start the application:
   ```
   dotnet run
   ```
4. Open your browser and navigate to the provided local address (usually `https://localhost:5001` or `http://localhost:5000`).

## Usage
- Use the navigation menu to switch between Home, Income, and Expenses pages.
- Add new income or expense records using the provided forms.
- View recent transactions and your current balance on the respective pages.

## Contributing
Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

## License
This project is licensed under the MIT License.
