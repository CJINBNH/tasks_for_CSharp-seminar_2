Console.Clear();
Console.WriteLine("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое второе: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());
if (numberOne%numberTwo == 0)
{
    Console.WriteLine("Является кратным");
}
else
{
    Console.WriteLine(numberOne%numberTwo);
}