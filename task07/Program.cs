//Выяснить является ли число чётным

bool OddOrEven (int a)
{
    return a%2==0;
}

OddOrEven(6);
if (OddOrEven(6)) Console.WriteLine("Число четное");
else Console.WriteLine("Число нечетное");