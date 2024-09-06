string x = Console.ReadLine();
string y = Console.ReadLine();

var axe1 = x.Split(' ');
var axe2 = y.Split(' ');

double x1 = double.Parse(axe1[0]);
double y1 = double.Parse(axe1[1]);

double x2 = double.Parse(axe2[0]);
double y2 = double.Parse(axe2[1]);

double distance = Math.Sqrt((Math.Pow(x2 - x1, 2)) + Math.Pow(y2 - y1, 2));

Console.WriteLine(Math.Round(distance, 4).ToString("F4"));