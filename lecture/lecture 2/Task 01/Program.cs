// Найти наибольшее число из 9 чисел , вариант 1
int a1 = 13;
int b1 = 15;
int c1 = 10;
int a2 = 17;
int b2 = 20;
int c2 = 23;
int a3 = 32;
int b3 = 30;
int c3 = 5;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);