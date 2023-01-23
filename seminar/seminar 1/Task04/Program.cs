Console.Write("Введите трёхзначное число - ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100 && number <= 1000)
    Console.Write($"Последняя цифра в числе {number} равна {number % 10}");
else
    Console.Write("Вы ввели не трёхзначное число");

