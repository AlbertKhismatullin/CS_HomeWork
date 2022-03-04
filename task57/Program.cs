// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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


void Print2D(int[,] a)
{
    int sort = 0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1) - 1; j++)
        {
            if (a[i, j] < a[i, j + 1])
            {
                sort = a[i, j];
                a[i, j] = a[i, j + 1];
                a[i, j + 1] = sort;
                sort = 0;
            }
            System.Console.Write($"{a[i,j], 4} |");
        }
        
       System.Console.WriteLine();  
    }
    
}

Random2D(a);
System.Console.WriteLine(" Массив после упорядочивания по убыванию элементов кождой строки: ");
Print2D(a);
