// Показать числа от -N до N

int x = 0; 
int y = 0; 
int res = 0;
string s = String.Empty;

System.Console.WriteLine("Введите отрицательное число -N");
s = Console.ReadLine();
x = Convert.ToInt32(s);

System.Console.WriteLine("Введите положительное число N");
s = Console.ReadLine();
y = Convert.ToInt32(s);

res = y - x;
int [] arr = new int [res+1];
arr[0]= x;
arr[res] = y;

for (int i = 1; i < arr.Length-1; i++)
{
    arr[i] = arr[i-1] + 1;
}

for (int j = 0; j < arr.Length; j++)
{
    Console.Write(arr[j] + " ");
}
