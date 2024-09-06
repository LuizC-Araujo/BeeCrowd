double radius = double.Parse(Console.ReadLine());

const double PI = 3.14159;

double volume = (4.0 / 3) * PI * (radius * radius * radius);

Console.WriteLine($"VOLUME = {volume.ToString("F3")}");
