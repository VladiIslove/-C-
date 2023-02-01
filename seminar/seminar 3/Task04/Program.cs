// апишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number > 0)
{
    TableSquare(number); // это число передаём в метод void
}
else System.Console.WriteLine("Не натуральнле число");

void TableSquare(int num)
{
    int count =1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 5} {Math.Pow(count, 2), 5}");  // \t отступ в лево ,
        Console.WriteLine();
        count++;
    }
}