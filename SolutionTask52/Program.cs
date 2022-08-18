// метод, создающий рандомный двумерный массив с указаными параметрами
int[,] FillTwoDimArray(int countRow, int countColumn)
{
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 10);
            j++;
        }
        i++;

    }
    return outArray;
}

//метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;
    Console.WriteLine();
    while (i < inputArray.GetLength(0)) //количество строк
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

// метод вычисляющий сумму значений в каждом столбце
double[] CalculeteColumn(int[,] masArray)
{
    int rowLength = masArray.GetLength(0);
    int colLength = masArray.GetLength(1);
    double[] calcArray = new double[masArray.GetLength(1)];

    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            calcArray[i] += masArray[j, i];


        }

    }

    return calcArray;
}

// метод находящий среднее арефметическое значений в каждом столбце
double[] AvgColumn(double[] firstArray, int[,] seconArray)
{
    double[] avg = new double[firstArray.Length];
    int i = 0;
    while (i < firstArray.Length)
    {
        avg[i] = firstArray[i] / seconArray.GetLength(0);
        i++;
    }
    return avg;
}

//метод печати результата
void PrintResultArray(double[] resultArray)
{
    int i = 0;
    
    while (i < resultArray.Length - 1)
    {
        Console.Write(resultArray[i] + ", ");
        i++;
    }

    Console.WriteLine(resultArray[i]);
    Console.WriteLine();
}

int[,] twoDimArray = FillTwoDimArray(4, 4);
PrintTwoDimArray(twoDimArray);
CalculeteColumn(twoDimArray);
double[] bufArray = CalculeteColumn(twoDimArray);
AvgColumn(bufArray, twoDimArray);
PrintResultArray(AvgColumn(bufArray, twoDimArray));