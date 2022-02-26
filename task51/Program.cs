// Задать двумерный массив следующим правилом: Aₘₙ = m+n

System.Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());

int[,] a = new int [m,n];

for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i,j] = i + j;
            System.Console.WriteLine($"{i} | {j} | {a[i,j]}");
        }
           
        System.Console.WriteLine();
    }

