decimal monthlySalary = 200000m;
decimal monthlyallowance = 50000m;

decimal totalMonthlyIncome = monthlySalary + monthlyallowance;
decimal annualIncome = totalMonthlyIncome * 12;

bool isPermanentEmployee = true;

Console.WriteLine($"Total Monthly Income:{totalMonthlyIncome}");
Console.WriteLine($"annual Income: {annualIncome}");
Console.WriteLine(monthlySalary - monthlyallowance);
Console.WriteLine(totalMonthlyIncome > 200000m);
Console.WriteLine(totalMonthlyIncome > 150000m && isPermanentEmployee);

 