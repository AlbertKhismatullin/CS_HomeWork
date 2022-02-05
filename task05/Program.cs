//Найти максимальное из трех чисел

int a = 7;
int b = 4;
int c = 9;

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
