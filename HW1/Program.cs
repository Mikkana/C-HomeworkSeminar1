// Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.
// Console.WriteLine("Введите первое число: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Наибольшее число: ");
// if(x > y)
// {
//     Console.Write(x);
// }
// else
// {
//     Console.WriteLine(y);
// }

// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.

// Console.WriteLine("Введите первое число");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int z = Convert.ToInt32(Console.ReadLine());
// Console.Write("Наибольшее число: ");
// int maxnum = 0;
// if( x > y)
// {
//     maxnum = x;    
// }
// else
// {
//     maxnum = y;
// }
// if(maxnum < z)
// {
//     maxnum = z;
// }
// Console.Write(maxnum);

// Задача 6: Напишите программу, которая на вход принимает число и выдает, является ли число четным (делится ли оно на два без остатка).

// Console.WriteLine("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// if(x%2 == 0)
// {
// Console.WriteLine("Число чётное");
// }
// else
// {
//     Console.WriteLine("Число нечётное");
// }

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите конечное чётное число");
int n = Convert.ToInt32(Console.ReadLine());
int i = 1;
while(i < n)
{
    if(i%2 == 0)
    {
        Console.Write(i + " ");
    }
    i++;
}