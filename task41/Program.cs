﻿//Выяснить являются ли три числа сторонами треугольника

bool IsTreug(double x, double y, double z)
{
    return (x + y > z && x + z > y && y + z > x);
}

double a = 10, b = 4, c = 7;
//(условие)?Вернуть, если истина:вернуть, если ложь
System.Console.WriteLine($"{a} {b} {c} - " + (IsTreug(a,b,c)?"Эти числа являются сторонами треугольника":"Эти числа не являются сторонами треугольника"));