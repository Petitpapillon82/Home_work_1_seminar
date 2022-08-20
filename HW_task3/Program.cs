Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()); 
int x = number;
if (x%2==0)
{
    Console.WriteLine($"число {x} чётное");
}
else
{
    Console.WriteLine($"число {x} нечётное");
}