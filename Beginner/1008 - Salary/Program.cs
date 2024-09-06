int employeeNumber = int.Parse(Console.ReadLine());
int workedHours  = int.Parse(Console.ReadLine());
double hourPrice = double.Parse(Console.ReadLine());

Console.WriteLine($"NUMBER = {employeeNumber}");
Console.WriteLine($"SALARY = U$ {Math.Round(workedHours * hourPrice, 2).ToString("F2")}");
