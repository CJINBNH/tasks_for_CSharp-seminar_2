﻿Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number%7 == 0 && number%23 == 0)
{
    Console.WriteLine("Является кратным");
}
else
{
    Console.WriteLine("Не подходит");
}
