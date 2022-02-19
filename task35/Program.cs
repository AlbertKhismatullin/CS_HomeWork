//Определить, присутствует ли в заданном массиве, некоторое число

int[] a = new int[20];

for (int i = 0; i < a.Length; i++)
    a[i] = new Random().Next(0, 101);

for (int i = 0; i < a.Length; i++)
    System.Console.Write($"{a[i]} ");

int n = 0;
bool f = false;
string s = String.Empty;
System.Console.WriteLine();
System.Console.WriteLine("Введите число для поиска в массиве");
s = Console.ReadLine();
n = Convert.ToInt32(s);

for (int i = 0; i < a.Length; i++)
{
    if(a[i] == n)
    {
        f = true;
        break;
    }
}
if(f) System.Console.WriteLine("Введенное число присутствует в массиве");
else System.Console.WriteLine("Введенное число в массиве отсутствует");