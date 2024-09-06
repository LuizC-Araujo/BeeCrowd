int km = int.Parse(Console.ReadLine());
double liters = double.Parse(Console.ReadLine());

Console.WriteLine($"{Math.Round(km / liters, 3).ToString("F3")} km/l");