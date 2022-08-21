//программа, которая будет находить строку с наименьшей суммой элементов.
//-----------------------------------------------------------------------

// получение данных от пользователя
int[] ReadData()
{
    Console.Clear();
    Console.WriteLine("MinOfRow");
    Console.WriteLine("Welcome!");
    Console.WriteLine();
    Console.Write("Задайте количество строк массива: ");
    int row = int.Parse(Console.ReadLine());
    Console.Write("Задайте количество столбцов массива: ");
    int column = int.Parse(Console.ReadLine());
    int[] data = new int[2] { row, column };
    return data;
}

// метод, создающий рандомный двумерный массив с указаными параметрами
int[,] FillTwoDimArray(int[] data)
{
    int countRow = data[0];
    int countColumn = data[1];
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0;
    int[,] outArray = new int[countRow, countColumn];
    while (i < countRow)
    {
        j = 0;
        while (j < countColumn)
        {
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;

    }
    return outArray;
}

//метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    Console.WriteLine("Вот Ваш массив:");
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

// метод вычисляющий сумму элементов в каждой строке
int[] SumOfElementsRow(int[,] inputArray)
{

    int rowLength = inputArray.GetLength(0);
    int colLength = inputArray.GetLength(1);
    int[] sumRowArray = new int[inputArray.GetLength(0)];

    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            sumRowArray[i] += inputArray[i, j];

        }
    }

    return sumRowArray;
}

// метод сравнивающий знчеия сумм элементов в каждой строке 
int Сomparison(int[] sumArray)
{
    int min = sumArray[0];
    int index = 0;

    for (int i = 1; i < sumArray.Length; i++)
    {

        if (min > sumArray[i])
        {

            min = sumArray[i];

            index = i;
        }
    }
    return index;
}

// метод выводящий номер строки с минимальной суммой элементов
void PrintNumRow(int index)
{
    Console.WriteLine("Номер строки с наименьшей суммой элементов:" + (index + 1));
}


int[] inputData = ReadData();
FillTwoDimArray(inputData);
int[,] twoDimArray = FillTwoDimArray(inputData);
PrintTwoDimArray(twoDimArray);
SumOfElementsRow(twoDimArray);
Сomparison(SumOfElementsRow(twoDimArray));
PrintNumRow(Сomparison(SumOfElementsRow(twoDimArray)));