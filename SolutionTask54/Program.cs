//программа, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
//--------------------------------------------------------------------------------------

// получение данных от пользователя
int[] ReadData()
{
    Console.Clear();
    Console.WriteLine("SortRowArray");
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

// метод сортирующий значения в строках массива
int[,] Filter(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        int[] oneArray = new int[inputArray.GetLength(1)];
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            oneArray[j] = inputArray[i, j];
            //метод сортировки по возрастанию
            Array.Sort(oneArray);
            //метод реверса
            Array.Reverse(oneArray);
        }

        for (int m = 0; m < inputArray.GetLength(1); m++)
        {
            inputArray[i, m] = oneArray[m];
        }
    }
    return inputArray;
}

//метод печатающий отсортированый массив
void PrintModTwoDimArray(int[,] modInputArray)
{
    int i = 0; int j = 0;
    Console.WriteLine();
    while (i < modInputArray.GetLength(0)) //количество строк
    {
        j = 0;
        while (j < modInputArray.GetLength(1))
        {
            Console.Write(modInputArray[i, j] + "   ");
            j++;
        }
        Console.Write("\n");
        Console.WriteLine();
        i++;
    }


}

int[] inputData = ReadData();
FillTwoDimArray(inputData);
int[,] twoDimArray = FillTwoDimArray(inputData);
PrintTwoDimArray(twoDimArray);
Filter(twoDimArray);
PrintModTwoDimArray(Filter(twoDimArray));

