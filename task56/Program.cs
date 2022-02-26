// Написать программу, которая обменивает элементы первой строки и последней строки

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

int change = 0;
void Print2D(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            if(i==0)
            {
                change = a[i, j]; 
                a[i, j] = a[a.GetLength(0) - 1, j]; 
                a[a.GetLength(0) - 1, j] = change;
            }
            change = 0;
            System.Console.Write($"{a[i,j], 4} ");
        }
        
       System.Console.WriteLine();  
    }
    
}

Random2D(a);
System.Console.WriteLine();
Print2D(a);