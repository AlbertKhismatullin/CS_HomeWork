// Возведите число А в натуральную степень B используя цикл
int a = 0, b = 0, i = 0, degree = 1;
string s = String.Empty;

System.Console.WriteLine("Введите число А");
s = Console.ReadLine();
a = Convert.ToInt32(s);

System.Console.WriteLine("Введите степень числа В");
s = Console.ReadLine();
b = Convert.ToInt32(s);

while (i!=b)
{
    degree = degree*a;
    i++;
}

System.Console.WriteLine("Число {0} в степени {1} равно {2} ", a, b, degree);
