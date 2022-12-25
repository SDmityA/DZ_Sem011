// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// ******************Задача 1******************************
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] array= new int [10];
// int count=0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(100,1000);
//     if (array[i]%2==0)
//     {
//         count=count+1;
//     }
// }
// Console.WriteLine("Массив: ["+String.Join(",",array)+"]");
// Console.WriteLine();
// Console.WriteLine("Четных чисел в массиве: "+count);

// **************Конец***********************************
// **************Задача 2********************************
// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] array= new int [4];
// int sum=0;
// for (int i = 0; i < array.Length; i++)
// {
//      array[i]=new Random().Next(-10,11);
//      if (i%2<0||0<i%2)
//      {
//         sum=sum+array[i];
//      }
// }
// Console.WriteLine("Массив: ["+String.Join(",",array)+"]");
// Console.WriteLine();
// Console.WriteLine("Сумма чисел на нечетных позициях: "+sum);

// ****************************Конец****************************
// ***************************Задача 3**************************
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int [] array= new int [6];
// // int sum=0;
// int max=array[0];
// for (int i = 0; i < array.Length; i++)
// {
//     array[i]=new Random().Next(-10,100);
//     if (array[i]>max)
//     {
//     max=array[i];
//     }
// }
// int min=array[0];
// for (int j = 0; j < array.Length; j++)
// {
//     if (array[j]<min)
//     {
//         min=array[j];
//     }
// }
// Console.WriteLine("Массив: ["+String.Join(",",array)+"]");
// Console.WriteLine();
// Console.WriteLine("Разница между максимальным и минимальным: "+ (max-min));

// **********************Конец******************************************