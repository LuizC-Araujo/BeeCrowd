int[] ints = new int[6];
int[] ints2 = new int[6];
int[] notas = new int[] { 10000, 5000, 2000, 1000, 500, 200 };
int[] coins = new int[] { 100, 50, 25, 10, 5, 1 };

double number = double.Parse(Console.ReadLine());

int centavos = (int) (number * 100 + 0.5);

for (int i = 0, j = 0; i < 6; i++, j++)
{
    ints[i] = centavos / notas[j];
    centavos = centavos % notas[j];
}

Console.WriteLine("NOTAS");
for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"{ints[i]} nota(s) de R$ {(notas[i] / 100.0).ToString("F2")}");
}

for(int i  = 0, j = 0; i < ints.Length; i++, j++)
{
    ints2[i] = centavos / coins[j];
    centavos = centavos % coins[j];
}

Console.WriteLine("MOEDAS");
for (int i = 0; i < coins.Length; i++)
{
    Console.WriteLine($"{ints2[i]} moeda(s) de R$ {(coins[i] / 100.0).ToString("F2")}");
}