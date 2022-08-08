Console.Clear();
int number = new Random().Next(10, 100);
Console.WriteLine($"Наше случайное число: {number}");
int firstFigure = number / 10;
int secondFigure = number % 10;
if (firstFigure > secondFigure)
{
    Console.Write(firstFigure);
}
else
{
    Console.Write(secondFigure);
}

