string name = Console.ReadLine();
double salary = double.Parse(Console.ReadLine());
double totalSell = double.Parse(Console.ReadLine());
double percentage = 0.15;

double bonus = totalSell * percentage;

Console.WriteLine($"TOTAL = R$ {Math.Round(salary + bonus, 2).ToString("F2")}");