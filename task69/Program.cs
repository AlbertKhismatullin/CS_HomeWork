// Найти сумму элементов от M до N, N и M заданы

int SumRec (int M, int N)
{
    if (M == N) return N;
    else return M + SumRec(M + 1, N);
}
System.Console.WriteLine(SumRec(2, 10));