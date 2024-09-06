double A = double.Parse(Console.ReadLine());
double B = double.Parse(Console.ReadLine());
double C = double.Parse(Console.ReadLine());

Console.WriteLine($"MEDIA = {Math.Round(((A * 2) + (B * 3) + (C * 5)) / 10, 1).ToString("F1")}");

Console.ReadKey();