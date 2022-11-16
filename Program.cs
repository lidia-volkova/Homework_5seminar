// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] CreateNewArray (int size)
// {
//     int [] arr = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(100,1000);
//     }
//     return arr;
// }

// void ShowArray (int [] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.WriteLine();
// }

// int CheckTheEvenness (int [] arr)
// {
//     int evennums = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i]%2 == 0)
//         {
//             evennums = evennums + 1;
//         }
//     }
//     return evennums;
// }

// int [] newarray = CreateNewArray(4);
// ShowArray(newarray);

// Console.WriteLine($"количество чётных элементов массива: {CheckTheEvenness((newarray))}");

// Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] CreateNewArray (int size, int minVal, int maxVal)
// {
//     int [] arr = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(minVal,maxVal);
//     }
//     return arr;
// }

// void ShowArray (int [] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.WriteLine();
// }

// int NotEvenPos (int [] arr)
// {
//     int notevennums = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i%2 == 0)
//         {
//             notevennums = notevennums + arr[i];
//         }
//     }
//     return notevennums;
// }

// Console.WriteLine("Введите минимальное значение элементов массива: ");
// int minVal = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите максимальное значение элементов массива: ");
// int maxVal = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine()); 
// int [] newarray = CreateNewArray(size, minVal, maxVal);
// ShowArray(newarray);

// Console.WriteLine($"сумаа нечётных элементов: {NotEvenPos((newarray))}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.0 7.2 22.7 2.1 78.3] -> 76.2

// int [] CreateNewArray (int size, int minVal, int maxVal)
// {
//     int [] arr = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         arr[i] = new Random().Next(minVal,maxVal);
//     }
//     return arr;
// }

// void ShowArray (int [] arr)
// {
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]}, ");
//     }
//     Console.WriteLine();
// }

// int Difference (int [] arr)
// {
//     int min = 0;
//     int max = 0;
//     int difference = 0;
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i> max)
//         {
//             max = i;
//         }
//         if (i < min)
//         {
//             min = i;
//         }
//         difference = max - min;
//     }
//     return difference;

// }

// Console.WriteLine("Введите минимальное значение элементов массива: ");
// int minVal = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите максимальное значение элементов массива: ");
// int maxVal = Convert.ToInt32(Console.ReadLine()); 
// Console.WriteLine("Введите количество элементов массива: ");
// int size = Convert.ToInt32(Console.ReadLine()); 
// int [] newarray = CreateNewArray(size, minVal, maxVal);
// ShowArray(newarray);

// Console.WriteLine($"разница между максимальным и минимальным элементом массива: {Difference((newarray))}");