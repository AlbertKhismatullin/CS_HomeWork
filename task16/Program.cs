// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
int a = 0;
string s = String.Empty;

Console.WriteLine("Введите номер дня недели ");
s = Console.ReadLine();
a = Convert.ToInt32(s);

if(a == 6 | a ==7) 
{
    Console.WriteLine("Номер дня недели " + a + " является выходным");
}
else 
{
    Console.WriteLine("Номер дня недели " + a + " не является выходным");
}
