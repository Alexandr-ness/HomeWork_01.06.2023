// Задача 54: 
// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


// Console.Write("Введите количество строк: ");
// int line = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());

// int[,] array2d = new int[line,column];
// Console.WriteLine("Исходный массив; ");
// for (int i=0; i < array2d.GetLength(0); i++)
// {
//     for (int j=0; j < array2d.GetLength(1); j++)
//     {
//         array2d[i,j] = new Random().Next(1,10);
//         Console.Write(array2d[i,j] + " ");
//     }
//     Console.WriteLine();
    
// }
// // void SortToLower(int[,] array2d)
// {
//     for (int i = 0; i < array2d.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2d.GetLength(1); j++)
//         {
//             for (int k = 0; k < array2d.GetLength(1) - 1; k++)
//             {
//                 if (array2d[i, k] < array2d[i, k + 1])
//                 {
//                     int temp = array2d[i, k + 1];
//                     array2d[i, k + 1] = array2d[i, k];
//                     array2d[i, k] = temp;
//                 }
//             }
//         }
//     }
// }

// Console.WriteLine($"Отсортированный массив; ");
// {
//     for (int i = 0; i < array2d.GetLength(0); i++)
//     {
//         for (int j = 0; j < array2d.GetLength(1); j++)
//         {
//             Console.Write($"{array2d[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }




////////////////////////////////////////////////////////////////////////////

// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



// Console.Write("Введите количество строк: ");
// int line = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int column = Convert.ToInt32(Console.ReadLine());

// int[,] array2d = new int[line,column];
// Console.WriteLine("Исходный массив; ");
// for (int i=0; i < array2d.GetLength(0); i++)
// {
//     for (int j=0; j < array2d.GetLength(1); j++)
//     {
//         array2d[i,j] = new Random().Next(1,10);
//         Console.Write(array2d[i,j] + " ");
//     }
//     Console.WriteLine();

// }
//  int sumtotal = 0;

//  for (int i = 0; i < array2d.GetLength(0); i++) 
//     {
    
//         for (int j = 0; j < array2d.GetLength(1); j++)
//         {
//             sumtotal += array2d[i, j];
//         }
    
//     }
// Console.Write("Сумма всех элементов двухмерного массива равна: {0}", sumtotal);  

// int SumLine(int[,] array2d, int i)
// {
// int sum = array2d[i,0];
// for (int j = 1; j < array2d.GetLength(1); j++)
// {
// sum += array2d[i,j];
// }
// return sum;
// }

// int minSum = 1;
// int sum = SumLine(array2d, 0);
// for (int i = 1; i < array2d.GetLength(0); i++)
// {
// if (sum > SumLine(array2d, i))
// {
// sum = SumLine(array2d, i);
// minSum = i+1;
// }
// }
// Console.WriteLine($"\n Строка c наименьшей суммой элементов: {minSum}");






/////////////////////////////////////////////////////////////////////////////


// Задача 58: 

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


// Console.Write("Введите количество строк первой матрицы: ");
// int line1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов первой матрицы: ");
// int column1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество строк второй матрицы: ");
// int line2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов второй матрицы: ");
// int column2 = Convert.ToInt32(Console.ReadLine());


// int[,] matrix1 = new int[line1,column1];
// Console.WriteLine("Исходный массив 1; ");
// for (int i=0; i < matrix1.GetLength(0); i++)
// {
//     for (int j=0; j < matrix1.GetLength(1); j++)
//     {
//         matrix1[i,j] = new Random().Next(1,10);
//         Console.Write(matrix1[i,j] + " ");
//     }
//     Console.WriteLine();
    

// }

// int[,] matrix2 = new int[line2,column2];
// Console.WriteLine("Исходный массив 2; ");
// for (int i=0; i < matrix2.GetLength(0); i++)
// {
//     for (int j=0; j < matrix2.GetLength(1); j++)
//     {
//         matrix2[i,j] = new Random().Next(1,10);
//         Console.Write(matrix2[i,j] + " ");
//     }
//     Console.WriteLine();
  
// }


//     if (matrix1.GetLength(1) != matrix2.GetLength(0)) 
//     Console.WriteLine("Матрицы нельзя перемножать");
//     else
//     {
//     int[,] matrix_result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//     Console.WriteLine("Произведение двух матриц; ");
//        for (int i = 0; i < matrix1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix2.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix2.GetLength(0); k++)
//             {
//                 matrix_result[i, j] += matrix1[i, k] * matrix2[k, j];               
//             }           
//             Console.Write(matrix_result[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     }



///////////////////////////////////////////////

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07




// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[,] array2d = new int[size,size];
// Spiral(array2d, size);



// void Spiral(int[,] array2d, int n)
// {
// int i = 0, j = 0;
// int y = 1;
// for (int e = 0; e < n * n; e++)
// {
//     int k = 0;
//     do { array2d[i, j++] = y++; } while (++k < n - 1);
//     for (k = 0; k < n - 1; k++) array2d[i++, j] = y++;
//     for (k = 0; k < n - 1; k++) array2d[i, j--] = y++;
//     for (k = 0; k < n - 1; k++) array2d[i--, j] = y++;
//      ++i; ++j;
//     n = n < 2 ? 0 : n - 2;
// }
// }



// for (int i = 0; i < array2d.GetLength(0); i++)
// {
//     for (int j = 0; j < array2d.GetLength(1); j++)
//     {
//         if (array2d[i, j] < 10)
//         {
//             Console.Write("0" + array2d[i, j]);
//             Console.Write(" ");
//         }
//         else Console.Write(array2d[i, j] + " ");
//     }
//     Console.WriteLine();
// }







