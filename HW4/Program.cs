// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int n = new Random().Next(3, 11);
// int[] numarray = new int[n];

// for(int i = 0; i < numarray.Length; i++)
// {
//     numarray[i] = new Random().Next(100, 1000);
// }
// for(int i = 0; i < numarray.Length; i++)
// {
//     if(numarray[i] % 2 == 0)
//     {
//         Console.Write(numarray[i] + ", ");
//     }
// }

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// int n = new Random().Next(3, 11);
// int[] numarray = new int[n];
// int sumnum = 0;

// for(int i = 0; i < numarray.Length; i++)
// {
//     numarray[i] = new Random().Next(-100, 100);
// }
// Console.WriteLine(String.Join(", ", numarray));
// for(int i = 0; i < numarray.Length; i++)
// {
//     if(i % 2 != 0)
//     {
//         sumnum += numarray[i];
//     }
// }
// Console.WriteLine(sumnum);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

void Randomarray(double[] numarray)
{
for(int i = 0; i < numarray.Length; i++)
{
    numarray[i] = new Random().Next(-100, 100);
}
}
int n = new Random().Next(3, 11);
double[] numarray = new double[n];
double minnum = 0;
double maxnum = 0;
double difference = 0;
Randomarray(numarray);

Console.WriteLine(String.Join(", ", numarray));


for(int i = 0; i < numarray.Length; i++)
{
    if(numarray[i] < minnum)
    {
        minnum = numarray[i];
    }
    if(numarray[i] > maxnum)
    {
        maxnum = numarray[i];
    }
}
difference = maxnum - minnum;
Console.WriteLine(difference);