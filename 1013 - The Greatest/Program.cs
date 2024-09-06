//string values = Console.ReadLine();

//var val = values.Split(' ');

//int a = int.Parse(val[0]);
//int b = int.Parse(val[1]);
//int c = int.Parse(val[2]);

//int biggestAB = Math.Max(a, b);
//int biggestOne = Math.Max(biggestAB, c);

//Console.WriteLine($"{biggestOne} eh o maior");

string values = Console.ReadLine();

var val = values.Split(' ');

List<int> list = new List<int>();

for (int i = 0; i < val.Length; i++)
{
    list.Add(int.Parse(val[i]));
}

int maior = list.Max();

Console.WriteLine($"{maior} eh o maior");