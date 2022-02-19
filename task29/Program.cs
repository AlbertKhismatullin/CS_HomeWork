// Написать программу вычисления произведения чисел от 1 до N

int N = 0, product = 1;
string s = string.Empty;

System.Console.WriteLine("Введите число N");
s = Console.ReadLine();
N = Convert.ToInt32(s);

for (int i = 1; i <= N; i++)
{
    product = product * i;
}

System.Console.WriteLine("Произведение чисел от 1 до " + N + " равно "+ product);
