// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int [] a = new int [12];
int sum = 0;

for(int i = 0;i < a.Length; i++)
    a[i]=new Random().Next(0,12);

System.Console.WriteLine();

for(int i = 0; i < a.Length; i++)   
    System.Console.Write($"{a[i]} ");

for (int i = 0; i < a.Length; i++)
{
    if(i%2 != 0) sum = sum + a[i];
}
System.Console.WriteLine();
System.Console.WriteLine("Сумма чисел, стоящих на нечетной позиции, равна " + sum);
