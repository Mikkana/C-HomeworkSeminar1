// //Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Введите пятизначное число");
// int number = Convert.ToInt32(Console.ReadLine());

// int firstnum = number/10000;
// int secondnum = number % 10000 /1000;
// int thirdnum = number % 1000 / 100;
// int fourthnum = number % 100 / 10;
// int fifthnum = number % 10;
// if(firstnum == fifthnum && secondnum == fourthnum)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }
// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.WriteLine("Введите координаты первой точки");
// Console.Write("x = ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y = ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("z = ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты второй точки");
// Console.Write("x = ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("y = ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("z = ");
// int z2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("x = ");

// double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

// Console.WriteLine("Расстояние между точками равно " + Math.Round(result, 2));
// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите положительное число");
int num = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i <= num; i++)
{
    Console.Write(Math.Pow(i, 3) + "; ");
}