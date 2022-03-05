// Показать натуральные числа от M до N, N и M заданы

string NumbersRec(int M, int N)
{
    if (N >= M) return $"{M} " + NumbersRec(M + 1, N);
    else return String.Empty;
}

System.Console.WriteLine(NumbersRec (6, 26));