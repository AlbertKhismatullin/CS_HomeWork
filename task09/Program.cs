// Показать четные числа от 1 до N

int a = 0;

Console.WriteLine("Введите число N");
string s = string.Empty;
s = Console.ReadLine();
a = Convert.ToInt32(s);

for (int i = 1; i <= a; i++)
{
    if(i%2 == 0) Console.Write(i + " ");
}