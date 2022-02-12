// Удалить вторую цифру трёхзначного числа

int a = 0;
string s = string.Empty;

Console.WriteLine("Введите трехзначное число ");
s = Console.ReadLine();
a = s.Length;

if(a == 3) 
{
    Console.WriteLine("Удалить вторую цифру " + s[s.Length-2]); 
    Console.WriteLine("Остается цифра " + s[s.Length-3] + s[s.Length-1]);
}

