//
int[] array = { 12, 23, 34, 45, 75, 86, 97, 18 };

int n = array.Length; // длина массива
int find = 4;

int index = 0;

while (index < n) // Если index < n
{
    if (array[index] == find) // Тогда array c [index] == find
    {
        Console.WriteLine(index); // выводим index числа
        break; // прерывание  
    }
    index++;  //index = index + 1 (Если нет то увеличиваем индекс на 1)    
}
