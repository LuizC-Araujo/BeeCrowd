int spentTime = int.Parse(Console.ReadLine());
int averageSpeed = int.Parse(Console.ReadLine());

const double consume = 12.0;

double liters = Math.Round(spentTime * averageSpeed / consume, 3);

Console.WriteLine(liters.ToString("F3"));