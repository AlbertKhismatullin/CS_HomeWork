// Определить сколько чисел больше 0 введено с клавиатуры

int count=0, a;
Console.WriteLine("Введите любое число");
string s = Console.ReadLine();
a = Convert.ToInt32(s);

while (a>0)
{
    if (a%10!=0) count++;
    a=a/10;
}

Console.WriteLine("Больше нуля введено чисел "+ count);
