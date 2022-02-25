// В указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

double [] a = new double [12];

for(int i = 0;i < a.Length; i++)
    a[i]=new Random().Next(1,12) / 10.1;

System.Console.WriteLine();

for(int i = 0; i < a.Length; i++)   
    System.Console.Write($"{a[i]:F2} |");

System.Console.WriteLine();

double min, max, diff;
min = a [0];
max = a [0];
for (int i = 0; i < a .Length; i++)
{
    if (a [i] > max) max = a [i];
    if (a [i] < min) min = a [i];
}

diff = max - min;
System.Console.WriteLine();
System.Console.WriteLine("Минимальное число в массиве: {0:F2} | Максимальное число в массиве: {1:F2} | Разница между min и max: {2:F2}", min, max, diff);
