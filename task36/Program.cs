// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int[] a = new int[12];
int even = 0, odd = 0;
for (int i = 0; i < a.Length; i++)
{
    a[i] = new Random().Next(100, 1000);
    System.Console.Write($"{a[i]} ");
    if (a[i]%2 == 0 ) even++;
    else odd++;
}
    
System.Console.WriteLine();
System.Console.WriteLine("Количество четных чисел массива " + even);
System.Console.WriteLine("Количество нечетных чисел массива " + odd);