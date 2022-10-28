/*Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"*/

string NumbersRec(int a)
{
if (1 <= a) return $"{a} " + NumbersRec(a - 1);
else return String.Empty;
}

Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NumbersRec(a));


/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

// int NumbersRec(int x, int y)
// {
// if (y == x) return x;
// return x + NumbersRec(x + 1, y);
// }
// Console.WriteLine("Введите первое число:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма чисел от {m} до {n} = {NumbersRec(m, n)}"); 