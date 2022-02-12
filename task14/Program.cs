// Выяснить, кратно ли число заданному, если нет, вывести остаток

int a = 0, b = 0;
string s;

Console.WriteLine("Введите первое число ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

Console.WriteLine("Введите второе число ");
s = Console.ReadLine();
b = Convert.ToInt32(s);

if(a%b == 0)
{
    Console.WriteLine("Первое число " + a + " кратно второму числу " + b);
}
else 
{
    Console.WriteLine("Остаток от деления первого числа " + a + " на второе число " + b +" равен " + a%b);
}
