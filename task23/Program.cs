// Показать таблицу квадратов чисел от 1 до N
int a = 0;

System.Console.WriteLine("Введите число N");
string s = string.Empty;
s = Console.ReadLine();
a = Convert.ToInt32(s);

for (int i = 1; i <= a; i++)
{
    System.Console.Write(Math.Pow(i,2) + " ");
}
