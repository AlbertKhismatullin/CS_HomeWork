// В двумерном массиве n×k заменить четные элементы на противоположные

Console.Clear();
System.Console.WriteLine("Введите количество строк n");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов k");
int k = int.Parse(Console.ReadLine());

int[,] a = new int [n, k];

for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j] = new Random().Next(1,10);
            System.Console.Write($"{a[i,j], 4} ");
        }
        System.Console.WriteLine();
    }
System.Console.WriteLine();
for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (a[i,j]%2 == 0) a[i,j] = -a[i,j];
            System.Console.Write($"{a[i,j], 4} ");
        }
        System.Console.WriteLine();
    }
