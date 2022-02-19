// Показать кубы чисел, заканчивающихся на четную цифру

double a, b;
Console.WriteLine("Введите число, до которого будут показаны кубы");
a = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    b = Math.Pow(i, 3);
    if (b % 2 == 0) 
    {
        System.Console.WriteLine("куб четного числа " + i + " равен " + b);
    }
}

