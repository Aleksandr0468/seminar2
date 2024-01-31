/*Задача 4: Напишите программу, которая на вход
принимает натуральное число N, а на выходе
показывает его цифры через запятую.*/

int num = 568;
int ten = 1;

while (ten < num / 10)
{
    ten = ten * 10;
}
while (ten > 0)
{
    int res = num / ten;
    num = num % ten;
    ten = ten / 10;
    System.Console.Write(res);

    if (ten >= 1)
    System.Console.Write(",");
}