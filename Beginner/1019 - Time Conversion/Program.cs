﻿int seconds = int.Parse(Console.ReadLine());

int hours = seconds / 3600;
seconds = seconds % 3600;

int minutes = seconds / 60;
seconds = seconds % 60;

Console.WriteLine($"{hours}:{minutes}:{seconds}");