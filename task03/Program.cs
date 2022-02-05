//Даны два числа. Показать большее и меньшее число

int a = 7;
int b = 5;

int max = a;
int min = b;
if (b > a) 
{
    max = b;
    min = a;
}
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);

