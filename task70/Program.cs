// Найти сумму цифр числа

int SumRec (int N)
{
    if (N/10 == 0) return N;
    else return N%10 + SumRec(N/10);
}
System.Console.WriteLine(SumRec(555));
