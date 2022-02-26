// // В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

// int x, y;
// int[,] a;

// void Input(out int x, out int y)
// {
//     System.Console.WriteLine("Введите количество строк массива: ");
//     x = int.Parse(System.Console.ReadLine());

//     System.Console.WriteLine("Введите количество столбцов массива: ");
//     y = int.Parse(System.Console.ReadLine());
// }

// void FillArray(int x, int y)
// {
//     a = new int[x,y];

//     for (int i = 0; i < a.GetLength(0); i++)
//     {
//         for (int j = 0; j < a.GetLength(1); j++)
//         {
//             a[i,j] = new Random().Next(-100,100);
//         }
//     }
// }

// void Solve(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             if(i%2==0 && j%2==0)
//             {
//                 arr[i,j] = (int) Math.Pow(arr[i,j], 2);
//             }
//         }
//     }
// }

// void PrintArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             System.Console.Write($"{arr[i,j],6} |");
//         }
//         System.Console.WriteLine();
//     }
// }

// Input(out x, out y);
// FillArray(x, y);
// PrintArray(a);
// System.Console.WriteLine();
// Solve(a);
// PrintArray(a);

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
            a[i,j] = new Random().Next(2,10);
            System.Console.Write($"{a[i,j], 4} ");
        }
        System.Console.WriteLine();
    }
System.Console.WriteLine();
for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if (i%2==0 && j%2==0) a[i,j] = (int) Math.Pow(a[i,j], 2);
            System.Console.Write($"{a[i,j], 4} ");
        }
        System.Console.WriteLine();
    }