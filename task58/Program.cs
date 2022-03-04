// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

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
            a[i,j] = new Random().Next(1,100);
            System.Console.Write($"{a[i,j], 4} |");
        }
        System.Console.WriteLine();
    }
}


async void Print2D(int[,] a)
{
    int [,] arr = new int[a.GetLength(0), a.GetLength(1)];

    if (a.GetLength(0) != a.GetLength(1))
    {
        System.Console.WriteLine("Массив не квадратный");
    }
    else
    {
        for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    {
                        arr[i, j] = a[j, i];
                        System.Console.Write($"{arr[i,j], 4} |");
                    }
                    System.Console.WriteLine();
            }
           
         
    }
    
}

Random2D(a);
System.Console.WriteLine();
Print2D(a);
