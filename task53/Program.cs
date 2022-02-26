// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

Console.Clear();

// System.Console.WriteLine("Введите количество столбцов k");
// int k = int.Parse(Console.ReadLine());

int[,] a = new int [4, 4];

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

System.Console.WriteLine("Введите число ");
int n = int.Parse(Console.ReadLine());

void Print2D(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i,j] == n)
            {
                System.Console.Write($"{i, 4}, {j} ");
            }
        }
        System.Console.WriteLine(); 
    }
}

Random2D(a);
System.Console.WriteLine();
Print2D(a);