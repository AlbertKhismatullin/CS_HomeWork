/*Найти произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д.*/

int [] a = new int [12];
//int product = 1;

for(int i = 0;i < a.Length; i++)
    a[i]=new Random().Next(1,12);

System.Console.WriteLine();

for(int i = 0; i < a.Length; i++)   
    System.Console.Write($"{a[i]} ");

System.Console.WriteLine();
System.Console.WriteLine("Произведение пар чисел равно: ");

for (int i = 0; i < a.Length/2; i++)
{
    System.Console.WriteLine(a[i] * a[12-1-i] + " ");
}
System.Console.WriteLine();

