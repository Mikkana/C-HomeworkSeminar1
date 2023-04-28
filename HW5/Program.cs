// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

// Console.WriteLine("Введите числа через пробел");
// string text = Console.ReadLine();
// string[] textsplit = text.Split(" ");
// int count = 0;

// for(int i = 0; i < textsplit.Length; i++)
// {
//     double temp = Convert.ToDouble(textsplit[i]);
//     if(temp > 0)
//     {
//         count++;
//     }
// }
// Console.WriteLine("Чисел больше 0: " + count);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите первое число b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите четвёртое число k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double y = 0;
double x = 0;

// y = k1 * x + b1 -> -k1*x +y = b1
// y = k2 * x + b2 -> -k2*x +y = b2 

double det = -k1 * 1 - (-k2 * 1);
Console.WriteLine(det);
double xdet = b1 * 1 - (1 * b2);
double ydet = (-k1 * b2) - (-k2 * b1);
x = xdet/det;
y = ydet/ det;
Console.WriteLine($"Точка пересечения: [{x}, {y}]");