﻿// Программа проверяет пятизначное число на палиндром

int a = 0;
string s = string.Empty;

System.Console.WriteLine("Введите пятизначное число ");
s = Console.ReadLine();
a = s.Length;

int [] arr = new int[a];
for (int i = 0; i < a; i++)
    {
        arr[i] = Convert.ToInt32(s[i]);
    }
if(arr[0] == arr[4] && arr[1] == arr[3])
    {
        System.Console.WriteLine("Введенное число является полиндромом");
    }
else System.Console.WriteLine("Введенное число не является полиндромом");

