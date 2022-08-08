Console.Clear();
int number = new Random().Next(100,1000);
Console.WriteLine ($"Наше случайное число: {number}");
int firstFigure = number/100;
int thirdFigure = number%10;
Console.Write(firstFigure*10+thirdFigure);

