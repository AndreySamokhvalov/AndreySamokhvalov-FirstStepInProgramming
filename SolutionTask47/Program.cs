Console.Clear();
Console.WriteLine("double MxN"); //Задает двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Welcome!");
Console.WriteLine("Для создания двумерного массива, заполненого случайными");
Console.WriteLine("вещественными числами, введите количество строк:");
int countRow = int.Parse(Console.ReadLine());
Console.WriteLine("Теперь введите количество столбцов:");
int countColumn = int.Parse(Console.ReadLine());
Console.WriteLine("Вот Ваш массив:");
Console.WriteLine();

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
            outArray[i, j] = numberSyntezator.Next(0, 101);
            j++;
        }
        i++;

    }
    return outArray;
}

//метод, модифицирующий созданный массив, заменяя значения на вещественные
double[,] UpdateTwoDimArray(int[,] MAS)
{
    double[,] updArray = new double[MAS.GetLength(0), MAS.GetLength(1)];
    int i = 0; int j = 0;
    // создаем элемент класса Random и обращаемся к нему в (45,30)
    Random unit = new Random();

    while (i < MAS.GetLength(0))
    {
        j = 0;
        while (j < MAS.GetLength(1))
        {
            updArray[i, j] = unit.NextDouble() * 100;
            j++;
        }
        i++;
    }

    return updArray;
}

// Метод печати модифицированного массива
void PrintUpdateTwoDimArray(double[,] printArray)
{
    int i = 0; int j = 0;

    while (i < printArray.GetLength(0))
    {
        j = 0;
        while (j < printArray.GetLength(1))
        {
            // Используем Math.Round(переменная,количество знаков) для окугления
            Console.Write(Math.Round(printArray[i, j], 4) + "  ");
            j++;
        }
        Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

int[,] twoDimArray = FillTwoDimArray(countRow, countColumn);
UpdateTwoDimArray(twoDimArray);
double[,] bufArray = UpdateTwoDimArray(twoDimArray);
PrintUpdateTwoDimArray(bufArray);
Console.WriteLine("Значения округлены до четвертого знака после запятой");
Console.WriteLine();