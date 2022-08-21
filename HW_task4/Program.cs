Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()); 
int i = 1; 
while (i <= n)
{
    if (i % 2 == 0)
    {
        Console.Write($"{i}, ");      
    }
      i = i + 1;   
}
Console.WriteLine($"являются чётными в промежутке от 1 до {n}");