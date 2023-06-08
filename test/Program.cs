// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// int n = ReadInt("Введите число N: ");
// if(n < 0) Console.WriteLine("Число не является натуральным");
// else
// {
//     NatureNumsToN(n);
// }

// int ReadInt(string text)
// {
//     Console.WriteLine(text);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }
// void NatureNumsToN(int number)
// {
//     if(number < 1)
//     {
//         return;
//     }
//     NatureNumsToN(number -1);
//     Console.Write(number + " ");
// }

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int m = ReadInt("Введите число N: ");
// int n = ReadInt("Введите число M: ");
// int sum = 0;
// if(n < 0|| m < 0) Console.WriteLine("Числа не подходят. Одно число или оба не являются натуральными");
// else
// {
//     if(m > n)
//     {
//         Console.WriteLine("Число m меньше n, невозможно вывести числа от m до n");
//     }
//     else
//     {
//         Console.Write(NaturNumsSum(m, n));
//     }

// }


// int ReadInt(string text)
// {
//     Console.WriteLine(text);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }
// int NaturNumsSum(int numbermin, int numbermax)
// {
//     if(numbermin > numbermax)
//     {
//         return 0;
//     }
//     sum = sum + numbermin;
//     NaturNumsSum(numbermin+1, numbermax);
//     return sum;
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = ReadInt("Введите число N: ");
int n = ReadInt("Введите число M: ");

if (n < 0 || m < 0) Console.WriteLine("Числа не подходят. Одно число или оба не являются натуральными");
else
{
    Console.Write(ack(n, m));
}

int ReadInt(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int ack(int number1, int number2)
{
    if (number1 == 0)
    {
        return number2 + 1;
    }
    else if (number2 == 0)
    {
        return ack(number1 - 1, 1);
    }
    else
    {
        return ack(number1 - 1, ack(number1, number2 - 1));
    }
}