//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

//Console.WriteLine("Введите размер матрицы:");
//int rowCount = int.Parse(Console.ReadLine());
//int colCount = int.Parse(Console.ReadLine());
//int[,] arr = FullArray(rowCount, colCount);
//int[,] FullArray(int t, int i)
//{
//    int[,] arr = new int[t, i];
//    Random random = new Random();
//    for (int a = 0; a < t; a++)
//    {
//        for (int b = 0; b < i; b++)
//        {
//            arr[a, b] = random.Next(1, 9);
//        }
//    }
//    return arr;
//}

//void PrintArray(int[,] arr)
//{
//    for (int a = 0; a < arr.GetLength(0); a++)
//    {
//        for (int b = 0; b < arr.GetLength(1); b++)
//        {
//            Console.Write(arr[a, b] + " ");
//        }
//        Console.WriteLine();
//    }
//}

//Console.WriteLine("Исходный массив!");
//PrintArray(arr);

//void Insert (bool isRow, int dim, int[] source, int[,] dest)
//{
//    for(int k = 0; k < source.Length; k++)
//    {
//        if (isRow)
//            dest[dim, k] = source[k];
//        else
//            dest[k, dim] = source[k];
//    }
//}
//void VozvratArray(int[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//        for (int j = 0; j < arr.Length - i - 1; j++)
//        {
//            if (arr[j] < arr[j + 1])
//            {
//                int temp = arr[j];
//                arr[j] = arr[j + 1];
//                arr[j + 1] = temp;
//            }
//        }
//}
//Console.WriteLine("Упорядочили строки по убыванию!");
//int[] row = new int[colCount];
//for (int i = 0; i < rowCount; i++)
//{
//    for (int j = 0; j < colCount; j++)
//        row[j] = arr[j, i];
//    VozvratArray(row);
//    Insert(true, i, row, arr);
//}
//PrintArray(arr);

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


//Console.WriteLine("Введите размер матрицы:");
//int rowCount = int.Parse(Console.ReadLine());
//int colCount = int.Parse(Console.ReadLine());
//int[,] arr = FullArray(rowCount, colCount);
//int[,] FullArray(int t, int i)
//{
//    int[,] arr = new int[t, i];
//    Random random = new Random();
//    for (int a = 0; a < t; a++)
//    {
//        for (int b = 0; b < i; b++)
//        {
//            arr[a, b] = random.Next(1, 9);
//        }
//    }
//    return arr;
//}
//void PrintArray(int[,] arr)
//{
//    for (int a = 0; a < arr.GetLength(0); a++)
//    {
//        for (int b = 0; b < arr.GetLength(1); b++)
//        {
//            Console.Write(arr[a, b] + " ");
//        }
//        Console.WriteLine();
//    }
//}
//Console.WriteLine("Исходный массив!");
//PrintArray(arr);
//void SumStringArray(int[,] arr)
//{
//    int index = 0, minsum = 0;
//    for (int i = 0; i < arr.GetLength(0); i++)
//    {
//        int sum = 0;
//        for (int j = 0; j < arr.GetLength(1); j++)
//        {
//            sum += arr[i, j];
//        }
//        Console.WriteLine($"Сумма {i + 1} строки = {sum}");
//        if (i == 0)
//        {
//            minsum = sum;
//        }
//        else if (sum < minsum)
//        {
//            minsum = sum;
//            index = i;
//        }
//    }
//    string line = string.Empty;
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        line += arr[index, j] + " ";
//    }
//    Console.WriteLine($"{index + 1}  строка с минимальной суммой элементов: {line} !");
//}
//SumStringArray(arr);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


//Random rnd = new Random();
//int[,] CreateMatrix(int row, int col, int min, int max)
//{
//    int[,] matrix = new int[row, col];

//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//            matrix[i, j] = rnd.Next(min, max + 1);
//        }
//    }
//    return matrix;
//}
//void PrintMatrix(int[,] matrix)
//{
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        Console.Write(" ");
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],1} ");
//            else Console.Write($"{matrix[i, j],1}");
//        }
//        Console.WriteLine(" ");
//    }
//}
//int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
//{
//    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
//    if (matrix1.GetLength(1) == matrix2.GetLength(0))
//    {
//        for (int i = 0; i < matrix3.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix3.GetLength(1); j++)
//            {
//                matrix3[i, j] = 0;
//                for (int n = 0; n < matrix1.GetLength(1); n++)
//                {
//                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
//                }
//            }
//        }
//    }
//    return matrix3;
//}

//int[,] array = CreateMatrix(rnd.Next(2, 2), rnd.Next(2, 2), 2, 4);
//int[,] matrix = CreateMatrix(rnd.Next(2, 2), rnd.Next(2, 2), 2, 4);
//Console.WriteLine("Первая матрица");
//PrintMatrix(array);
//Console.WriteLine("Вторая матрица");
//PrintMatrix(matrix);
//Console.WriteLine("Результатирующая матрица");
//PrintMatrix(DivMatrix(array, matrix));
//Console.ReadLine();

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу,
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
//int[,,] CreateMatrix(int row, int col, int dep, int min, int max)
//{
//    int[,,] matrix = new int[row, col, dep];
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//            for (int k = 0; k < matrix.GetLength(2); k++) { matrix[i, j, k] = GetUniqueValue(matrix, min, max, i, j, k); }
//        }
//    }
//    return matrix;
//}
//Random rnd = new Random();
//int GetUniqueValue(int[,,] matrix, int min, int max, int i, int j, int k)
//{
//    int value = default;
//    bool exist = true;
//    while (exist)
//    {
//        bool _break = false;
//        value = rnd.Next(min, max + 1);
//        for (int i1 = 0; i1 < matrix.GetLength(0); i1++)
//        {
//            if (_break) { break; }
//            for (int j1 = 0; j1 < matrix.GetLength(1); j1++)
//            {
//                if (_break) { break; }
//                for (int k1 = 0; k1 < matrix.GetLength(2); k1++)
//                {
//                    if (matrix[i1, j1, k1] == value) { _break = true; break; }
//                    if (i1 == i && j1 == j && k1 == k) { exist = false; }
//                }
//            }
//        }
//    }
//    return value;
//}
//void PrintMatrix(int[,,] matrix)
//{
//    for (int i = 0; i < matrix.GetLength(0); i++)
//    {
//        for (int j = 0; j < matrix.GetLength(1); j++)
//        {
//            Console.Write(" ");
//            for (int k = 0; k < matrix.GetLength(2); k++) { Console.Write($"{matrix[i, j, k],1}({i},{j},{k})  "); }
//            Console.WriteLine();
//        }
//    }
//}
//int[,,] arrayThreeD = CreateMatrix(2, 2, 2, 10, 99);
//Console.WriteLine();
//PrintMatrix(arrayThreeD);
//Console.ReadLine();


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
    sqareMatrix[i, j] = temp;
    temp++;
    if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
        j++;
    else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
        i++;
    else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
        j--;
    else
        i--;
}

WriteArray(sqareMatrix);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}