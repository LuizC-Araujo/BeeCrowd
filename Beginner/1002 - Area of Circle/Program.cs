double R = double.Parse(Console.ReadLine());

double PI = 3.14159;
double R2 = R * R;

string raio = Math.Round(R2 * PI, 4).ToString("F4");

Console.WriteLine($"A={raio}");