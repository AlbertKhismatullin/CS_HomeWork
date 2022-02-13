//Найти сумму чисел от 1 до А

int a = 0, sum = 0;

System.Console.WriteLine("Введите число A");
string s = string.Empty;
s = Console.ReadLine();
a = Convert.ToInt32(s);

for (int i = 1; i <= a; i++)
{
       sum = sum + i;
}
System.Console.Write(sum);
