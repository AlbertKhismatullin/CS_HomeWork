// Показать натуральные числа от 1 до N, N задано

string NumbersRec(int a, int N)
{
    if (N >= a) return $"{a} " + NumbersRec(a + 1, N);
    else return String.Empty;
}

System.Console.WriteLine(NumbersRec (1, 10));