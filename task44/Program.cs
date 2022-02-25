/* Найти точку пересечения двух прямых заданных уравнением 
 y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы*/

void PointAcross (int b1, int k1,int b2,int k2)
{
    int x = (b2 - b1) / (k1 - k2);
    int y = x * k2 + b2;
    System.Console.WriteLine("Точка пересечения прямых: x = {0} y = {1}" , x, y);
}
PointAcross(5,7,2,9);
