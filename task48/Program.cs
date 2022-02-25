//Показать двумерный массив размером m×n заполненный целыми числами

int[,] a = new int [3,2]{{1,2}, {3,4}, {5,6}};

void Print2D(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i,j],4}");
        System.Console.WriteLine();
    }

}
Print2D(a);