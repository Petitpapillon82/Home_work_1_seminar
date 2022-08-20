Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine()); 
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine()); 

if (number1 > number2) 
{
    Console.WriteLine($"max == {number1}, min == {number2}");
}
else 
{
    Console.WriteLine($"max == {number2}, min == {number1}");
}