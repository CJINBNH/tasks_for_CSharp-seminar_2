Console.Clear();
Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое второе: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne == numberTwo*numberTwo || numberTwo == numberOne*numberOne)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}