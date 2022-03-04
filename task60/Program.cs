// Составить частотный словарь элементов двумерного массива состоящих из чисел от 0 до 99

int[,] a = new int[5, 5];//Глобальная переменная
int[] freqArr = new int[100];

FillArray(a,0,100);
PrintArray(a);


for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        freqArr[a[i, j]]++;
    }
}

for(int i=0;i<freqArr.Length;i++)
    if (freqArr[i] != 0)
        Console.WriteLine($"{i}:{freqArr[i]}");


void FillArray(int[,] arr,int min=0,int max=100)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max);
        }
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j],3} |");
        }
        System.Console.WriteLine();
    }
}

