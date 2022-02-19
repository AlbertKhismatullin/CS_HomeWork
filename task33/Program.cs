/*Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
Найти сумму положительных/отрицательных элементов массива*/

int[] a = new int[12];
int b = 0, c = 0;
for (int i = 0; i < a.Length; i++)
{
    a[i] = new Random().Next(-9, 10);
    System.Console.Write($"{a[i]} ");
    if (a[i] > 0 ) b = b + a[i];
    if (a[i] < 0 ) c = c + a[i];
}
    
System.Console.WriteLine();
System.Console.WriteLine("Сумма положительных элементов массива " + b);
System.Console.WriteLine("Сумма отрицательных элементов массива " + c);