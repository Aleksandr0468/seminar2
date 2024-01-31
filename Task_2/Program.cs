/*Задача 2: Напишите программу, которая принимает
на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠
0 и выдаёт номер координатной четверти плоскости,
в которой находится эта точка.*/


int x = 2;
int y = 3;
int k = 0;

if (x > k && y > k)
{
    System.Console.WriteLine("1");
}
else if (x < k && y > k)
{
    System.Console.WriteLine("2");
}
else if (x < k && y < k)
{
    System.Console.WriteLine("3");
}
else if (x > k && y < k)
{
    System.Console.WriteLine("4");
}
else 
{
    System.Console.WriteLine("k");
}

