int days = int.Parse(Console.ReadLine());

int years = days / 365;
days = days % 365;

int months = days / 30;
days = days % 30;

Console.WriteLine($"{years} ano(s)"); 
Console.WriteLine($"{months} mes(es)"); 
Console.WriteLine($"{days} dia(s)"); 
