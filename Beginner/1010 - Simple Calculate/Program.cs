var p1 = Console.ReadLine();
var p2 = Console.ReadLine();

var product1 = p1.Split(' ');
var product2 = p2.Split(' ');

int product1Qtd = int.Parse(product1[1]);
double product1Value = double.Parse(product1[2]);

int product2Qtd = int.Parse(product2[1]);
double product2Value = double.Parse(product2[2]);

string valorTotal = Math.Round(product1Qtd * product1Value + product2Qtd * product2Value, 2).ToString("F2");

Console.WriteLine($"VALOR A PAGAR: R$ {valorTotal}");

Console.ReadKey();