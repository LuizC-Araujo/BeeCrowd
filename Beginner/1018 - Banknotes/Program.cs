int[] ints = new int[7];
int[] notas = new int[] { 100, 50, 20, 10, 5, 2, 1 };

int number = int.Parse(Console.ReadLine());
string givenNumber = number.ToString();

for  (int i = 0, j = 0; i < ints.Length; i++, j++)
{
    ints[i] = number / notas[j];
    number = number % notas[j];
}

Console.WriteLine(givenNumber);
for (int i = 0; i < notas.Length; i++)
{
    Console.WriteLine($"{ints[i]} nota(s) de R$ {notas[i]},00");
}


