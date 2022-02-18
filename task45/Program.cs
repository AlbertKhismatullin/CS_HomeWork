//Показать числа Фибоначчи

double Fibonacci(double n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (double i = 1; i < 40; i++)
{
    System.Console.WriteLine("Число Фибоначчи от {0} равно {1}", i, Fibonacci(i));
}