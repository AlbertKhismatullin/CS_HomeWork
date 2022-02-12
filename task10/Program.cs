// Показать последнюю цифру трёхзначного числа

int a = 0;
string s = string.Empty;

Console.WriteLine("Введите трехзначное число ");
s = Console.ReadLine();
a = s.Length;

if(a == 3) 
{
    Console.WriteLine("Последняя цифра трехзначного числа " + s[s.Length-1]);
}
