// Найти третью цифру числа или сообщить, что её нет

int a = 0;
string s = string.Empty;

Console.WriteLine("Введите любое число ");
s = Console.ReadLine();
a = s.Length;

if(a >= 3) 
{
    Console.WriteLine("Третья цифра числа " + s[s.Length-2]);
}
else
{
    Console.WriteLine("Третья цифра числа отсутствует ");
}
