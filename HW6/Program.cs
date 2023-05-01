// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

// Console.WriteLine("Введите количество строк");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов");
// int columns = Convert.ToInt32(Console.ReadLine());
// double[,] arraydouble = new double [rows, columns];
// for(int i = 0; i <arraydouble.GetLength(0); i++)
// {
//     for(int j = 0; j < arraydouble.GetLength(1); j++)
//     {
//         arraydouble[i,j] = Math.Round(new Random().NextDouble() * new Random().Next(-100, 101), 2);
//         Console.Write(arraydouble[i,j] + " ");
//     }
//     Console.WriteLine();
// }

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


// int rows = new Random().Next(3, 11);
// int columns = new Random().Next(3, 11);
// int[,] numarray = new int[rows,columns];
// Console.WriteLine("Введите номер строки");
// int rowindex = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите номер колонки");
// int columnindex = Convert.ToInt32(Console.ReadLine());
// bool checker = false;
// for(int i = 0; i < numarray.GetLength(0);i++)
// {
//     for(int j = 0; j < numarray.GetLength(1); j++)
//     {
//         numarray[i,j] = new Random().Next(1, 101);
//         if(i == rowindex && j == columnindex) 
//         {
//             checker = true;
//         }
//         Console.Write(numarray[i,j] + " ");
//     }
//     Console.WriteLine();
// }
// if(checker == false) Console.WriteLine("Такого индекса нет");
// else Console.WriteLine(numarray[rowindex,columnindex]);
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int rows = new Random().Next(3, 11);
int columns = new Random().Next(3, 11);
int[,] numarray = new int[rows,columns];
for (int i = 0; i < numarray.GetLength(0); i++)
{
    for (int j = 0; j < numarray.GetLength(1); j++)
    {
        numarray[i,j] = new Random().Next(1, 101);
        Console.Write(numarray[i,j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

for(int i = 0; i < numarray.GetLength(1); i++)
{
    double sumcolumn = 0;
    double ariphmean = 0;
    for(int j = 0; j < numarray.GetLength(0); j++)
    {
        sumcolumn += numarray[j,i];
    }
    ariphmean = Math.Round(sumcolumn / numarray.GetLength(0), 2);

    Console.Write(i + " = " + ariphmean + " ");
}