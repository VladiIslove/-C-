Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA > numberB)
{
    Console.WriteLine($"число {numberA} больше");
}
else if (numberB > numberA)
{
    Console.WriteLine($"число {numberB} больше");
}
