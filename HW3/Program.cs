// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введие число степени");
// int y = Convert.ToInt32(Console.ReadLine());
// double Pownum(int a, int b)
// {
//     double powab = Math.Pow(a, b);
//     return powab;
// }
// Console.WriteLine($"Число {x} в степени {y} равно {Pownum(x, y)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// int Sumnumbers(int num)
// {
//     int result = 0;

//     while(num > 0)
//     {
//         result = result + num % 10;
//         num = num / 10;
//     }
    
//     return result;
// }
// Console.WriteLine(Sumnumbers(number));

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
void ShowArrayFromInput(int[] value)
{
    int i = 0;
    while(i < value.Length)
        {
            Console.WriteLine("Введите число");        
            value[i] = Convert.ToInt32(Console.ReadLine());
            i++;
        }
    Console.WriteLine(String.Join(", ", value));
    }

int[] array = new int[8];

ShowArrayFromInput(array);








