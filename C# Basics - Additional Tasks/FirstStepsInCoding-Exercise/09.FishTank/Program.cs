
using System;

int l = int.Parse(Console.ReadLine());
int w = int.Parse(Console.ReadLine());
int h  = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

double tankVolume = l * w * h;

double tankInLiters = tankVolume / 1000;

double neededLiters = tankInLiters -  (tankInLiters * percent / 100);

Console.WriteLine(neededLiters);


