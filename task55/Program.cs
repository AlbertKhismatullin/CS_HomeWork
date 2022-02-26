// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

Console.Clear();

System.Console.WriteLine("Введите количество столбцов ");
int k = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());

int[,] a = new int [k, n];

void Random2D(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j] = new Random().Next(2,10);
            System.Console.Write($"{a[i,j], 4} ");
        }
        System.Console.WriteLine();
    }
}

int sum = 0, arithm = 0;
void Print2D(int[,] a)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        for (int i = 0; i < a.GetLength(0); i++)
        {
            sum = sum + a[i,j];
            arithm = sum / a.GetLength(0);
        }
        System.Console.Write($"{arithm, 4} ");
        sum = 0; 
    }
    
}

Random2D(a);
System.Console.WriteLine();
Print2D(a);