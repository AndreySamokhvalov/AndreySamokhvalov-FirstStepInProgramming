﻿//программа, которая будет находить произведение двух матриц 
//----------------------------------------------------------

// метод ввода данных от пользователя
int[] ReadDataFirst()
{
    Console.Clear();
    Console.WriteLine("MatrixMultiplyByMatrix");
    Console.WriteLine("Welcome!");
    Console.WriteLine();
    Console.Write("Задайте количество строк первой матрицы: ");
    int row = int.Parse(Console.ReadLine());
    Console.Write("Задайте количество столбцов первой матрицы: ");
    int column = int.Parse(Console.ReadLine());
    int[] data = new int[2] { row, column };
    return data;
}

// метод ввода данных от пользователя
int[] ReadDataSecond()
{
    Console.WriteLine();
    Console.Write("Задайте количество строк второй матрицы: ");
    int row = int.Parse(Console.ReadLine());
    Console.Write("Задайте количество столбцов второй матрицы: ");
    int column = int.Parse(Console.ReadLine());
    int[] data = new int[2] { row, column };
    return data;
}

// метод, создающий матрицу с указаными параметрами
int[,] FillTwoDimArray(int[] data)
{
    int countRow = data[0];
    int countColumn = data[1];
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] firstOutArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            firstOutArray[i, j] = numberSyntezator.Next(0, 10);
            j++;
        }
        i++;

    }
    return firstOutArray;
}

//метод для печати  матриц
void PrintTwoDimArray(int[,] inputArray)
{
    Console.WriteLine("Матрица:");
    Console.WriteLine();
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + "   ");
            j++;
        }

        Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

// метод для вычисления перемноженной матрицы
int[,] СompositionArray(int[,] firsttArray, int[,] secondArray)
{
    int rowLengthOne = firsttArray.GetLength(0);
    int colLengthOne = firsttArray.GetLength(1);
    int rowLengthTwo = secondArray.GetLength(0);
    int colLengthTwo = secondArray.GetLength(1);
    int[,] compositArray = new int[firsttArray.GetLength(0), secondArray.GetLength(1)];
    // проверка условия перемножения матриц
    if (firsttArray.GetLength(1) != secondArray.GetLength(0))
    {
        Console.WriteLine("Матрицы с такими параметрами нельзя перемножить");
        System.Environment.Exit(0);

    }
    else
    {
        for (int i = 0; i < firsttArray.GetLength(0); i++)
        {
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                for (int k = 0; k < secondArray.GetLength(0); k++)
                {
                    compositArray[i, j] += firsttArray[i, k] * secondArray[k, j];
                }
            }
        }
    }

    return compositArray;
}

int[] inputDataFirst = ReadDataFirst();
int[] inputDataSecond = ReadDataSecond();
int[,] firstTwoDimArray = FillTwoDimArray(inputDataFirst);
PrintTwoDimArray(firstTwoDimArray);
int[,] secondTwoDimArray = FillTwoDimArray(inputDataSecond);
PrintTwoDimArray(secondTwoDimArray);
СompositionArray(firstTwoDimArray, secondTwoDimArray);
PrintTwoDimArray(СompositionArray(firstTwoDimArray, secondTwoDimArray));