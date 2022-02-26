// В матрице чисел найти сумму элементов главной диагонали

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

int sum = 0;
void Print2D(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (i == j) 
            {
                sum = sum + a[i,j]; 
            }
        } 
    }
    System.Console.Write($"Сумма элементов главной диагонали: {sum} ");
}

Random2D(a);
System.Console.WriteLine();
Print2D(a);