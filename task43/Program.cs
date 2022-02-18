//Написать программу преобразования десятичного числа в двоичное

int a = 8, b = a, c;
string s = " ";
while (b > 0)
{
    c = b%2;
    s = c.ToString() + s;
    b = b/2;
}
System.Console.WriteLine("Число - {0} в двоичной системе равно {1}", a, s);

