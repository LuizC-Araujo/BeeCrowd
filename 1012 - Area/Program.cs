string values = Console.ReadLine();

var val = values.Split(' ');

double A = double.Parse(val[0]);
double B = double.Parse(val[1]);
double C = double.Parse(val[2]);

const double PI = 3.14159;

double triangleArea = (A * C) / 2;
double circleArea = PI * (C * C);
double trapeziumArea = ((A + B) * C) / 2;
double squareArea = B * B;
double rectangleArea = A * B;

Console.WriteLine($"TRIANGULO: {triangleArea:F3}");
Console.WriteLine($"CIRCULO: {circleArea:F3}");
Console.WriteLine($"TRAPEZIO: {trapeziumArea:F3}");
Console.WriteLine($"QUADRADO: {squareArea:F3}");
Console.WriteLine($"RETANGULO: {rectangleArea:F3}");
