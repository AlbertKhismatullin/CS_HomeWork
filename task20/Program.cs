﻿// Задать номер четверти, показать диапазоны для возможных координат

int a = 0;
string s = String.Empty;

System.Console.WriteLine("Введите номер четверти координатной плоскости ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

if(a == 1) {
    System.Console.WriteLine("Диапазоны возможных координат: по осям x и y - от 0 до бесконечности");
}
if(a == 2) {
    System.Console.WriteLine("Диапазоны возможных координат: по оси x: от минус бесконечности до 0; по оси y: от 0 до бесконечности");
}
if(a == 3) {
    System.Console.WriteLine("Диапазоны возможных координат: по осям x и y: от минус бесконечности до 0");
}
if(a == 4) {
    System.Console.WriteLine("Диапазоны возможных координат: по оси x: от 0 до бесконечности; по оси y: от минус бесконечности до 0");
}
