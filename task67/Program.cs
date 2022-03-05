// Показать натуральные числа от N до 1, N задано

string NumbersRec(int a, int N)
{
    if (N >= a) return NumbersRec(a + 1, N) + $"{a} ";
    else return String.Empty;
}

System.Console.WriteLine(NumbersRec (1, 10));