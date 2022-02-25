//Показать двумерный массив размером m×n заполненный вещественными числами

double[,] a = new double [3,2]{{1.2,2.3}, {3.4,4.5}, {5.6,6.7}};

void Print2D(double[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i,j],6}");
        System.Console.WriteLine();
    }

}
Print2D(a);