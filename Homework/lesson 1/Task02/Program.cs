Console.Write("Введите первое число: ");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberc = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (numbera>numberb)
{
    max = numbera;
    Console.Write(max);
}
else if (numberb>numberc)
{
    max = numberb;
    Console.Write(max);
}
else if (numberc>numbera)
{
    max = numberc;
    Console.Write(max);
}