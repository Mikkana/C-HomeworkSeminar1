// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// int rows = new Random().Next(2,5);
// int columns = new Random().Next(3,5);

// int[,] numarray = new int[rows,columns];

// void FillArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,100);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// void SortArrayRows(int [,] array)
// {
//     int temp = 0;
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//             for(int j = 0; j < array.GetLength(1); j++)
//             {
//                     for(int k = 0; k < array.GetLength(1); k++)
//                     {
//                         if(array[i,j] > array[i,k])
//                         {
//                             temp = array[i,k];
//                             array[i,k] = array[i,j];
//                             array[i,j] = temp;
//                         }

//                     }
//             }
//     }
// }
// FillArray(numarray);
// PrintArray(numarray);
// Console.WriteLine("------------");
// SortArrayRows(numarray);
// PrintArray(numarray);

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// // Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
// int rows = new Random().Next(2,5);
// int columns = new Random().Next(3,5);
// // на случай, если получился квадрат
// if(rows == columns)
// {
//     while(rows == columns)
//     {
//         columns = new Random().Next(3,5);
//     }
// }
// int[,] numarray = new int[rows,columns];

// int[] sums = new int[rows];

// void FillArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,100);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
// void SumsInNewArray(int[] array, int[,] twoDimArray)
// {
//     int sum = 0;
//     for (int i = 0; i < twoDimArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < twoDimArray.GetLength(1); j++)
//         {
//             sum += twoDimArray[i,j];
//         }
//         array[i] = sum;
//         sum = 0;
//     }
// }
// void FindMinSum(int[] array)
// {
//     int minSumIndex = 0;
//     int temp = int.MaxValue;
//     for (int i = 0; i < array.Length; i++)
//     {
        
//         if(array[i] < temp)
//         {
//             temp = array[i];
//             minSumIndex = i+1;
//         }
//     }
// Console.WriteLine("Минимальная сумма элементов в строке " + minSumIndex);
// }
// FillArray(numarray);
// PrintArray(numarray);
// SumsInNewArray(sums, numarray);
// Console.WriteLine("_________");
// Console.WriteLine();
// Console.WriteLine(String.Join(',',sums));
// Console.WriteLine();
// FindMinSum(sums);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:

// int rows = new Random().Next(3,5);
// int columns = new Random().Next(3,5);
// int secondcolumns = new Random().Next(3,5);
// // При умножении матриц количество строк второй матрицы должно быть равно количеству столбцов второй матрицы
// int[,] firstArray = new int[rows,columns];
// int[,] secondArray = new int[columns,secondcolumns];
// int[,] multipliedArray = new int[rows,secondcolumns];

// void FillArray(int [,] array)
// {
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(1,10);
//         }
//     }
// }
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// void MultiplyArrays(int[,] arrayOne, int[,] arrayTwo)
// {
    
//     for(int i = 0; i < multipliedArray.GetLength(0);i++)
//     {
//         for(int j = 0; j < multipliedArray.GetLength(1); j++)
//         {
//             for(int k = 0; k < secondArray.GetLength(0); k++)
//             {
//                 multipliedArray[i,j] += firstArray[i,k] * secondArray[k, j];
//             }
//         }
//     }
// }
// FillArray(firstArray);
// PrintArray(firstArray);
// Console.WriteLine("-----------------");
// FillArray(secondArray);
// PrintArray(secondArray);
// Console.WriteLine("-----------------");
// MultiplyArrays(firstArray, secondArray);
// PrintArray(multipliedArray);

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
//  которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// int firstelems = 2;
// int secondelems = 2;
// int thirdelems = 2;


// int[,,] trippleArray = new int[firstelems,secondelems,thirdelems];
// int num = 10;

// void FillArray()
// {
//     for (int i = 0; i < trippleArray.GetLength(0); i++)
//     {
//      for (int j = 0; j < trippleArray.GetLength(1); j++)
//      {
//         for (int k = 0; k < trippleArray.GetLength(2); k++)
//         {
//             trippleArray[i,j,k] = num;
//             num++;
//         }
//      }  
//     }
// }

// void PrintTrippleArray(int[,,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for(int k = 0; k < array.GetLength(2); k++)
//             {
//                  Console.Write(array[i,j,k] + " " + "(" + i + j + k + ")" + " ");
//             }
//             Console.WriteLine();
//         }        
//     }
// }
// FillArray();
// PrintTrippleArray(trippleArray);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] spiralArray = new int[4,4];

void FillspiralArray()
{
    int num = 1;
    for(int i = 0; i < 3;)
    {
        for(int j = 0; j < 3; j++)
        {
            spiralArray[i,j] = num;
            num++;
        }
        break;
    }
    for(int j = 3; j == 3;)
    {
        for(int i = 1; i < 3; i++)
        {
            spiralArray[i,j] = num;
            num++;
        }
        break;
    }
    for (int i = 2; i == 2;)
    {
        for(int j = 2; j >= 0; j--)
        {
            spiralArray[i,j] = num;
            num++;
        }
        break;
    }
    for(int j = 0; j < 3;)
    {
        for(int i = 2; i > 0; i --)
        {
            spiralArray[i,j] = num;
            num++;
        }
        break;
    }
    for(int i = 2; i <= 3;)
    {
        for(int j = 2; j <= 3; j++)
        {
            spiralArray[i,j] = num;
            num++;
        }
        break;
    }
    spiralArray[2,2] = num++;
    spiralArray[2,1] = num++;
}

void PrintSpiralArray()
{
    for(int i = 0; i < spiralArray.GetLength(0); i++)
    {
        for(int j = 0; j < spiralArray.GetLength(1); j++)
        {
            Console.Write(spiralArray[i,j] + ", ");
        }
        Console.WriteLine();
    }
}

FillspiralArray();
PrintSpiralArray();