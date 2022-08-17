Console.Clear();
Console.WriteLine("Point [i,j]"); //Программа  которая на вход принимает позиции элемента в двумерном массиве, 
Console.WriteLine("Welcome!");//  и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Write("Введите позицию элемента в формате ");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("[i,j]");
Console.ResetColor();

// принимаем на вход позицию элемента в формате строки
string dataString = Console.ReadLine();

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


//метод для печати двумерного массива
void PrintTwoDimArray(int[,] inputArray)
{
    int i = 0; int j = 0;

    while (i < inputArray.GetLength(0))
    {
        j = 0;
        while (j < inputArray.GetLength(1))
        {
            Console.Write(inputArray[i, j] + "  ");
            j++;
        }
        Console.Write("\n");
        Console.WriteLine();
        i++;
    }
}

//метод преобразующий входные данные и определяющий 
//присутствие элемента на указанной позиции
void ShowValue(int[,] mas)
{
    char[] charsToTrim = { '[', ']' };
    string inputLine = dataString.Trim(charsToTrim);

    string showCountRowLn = inputLine.Substring(0, inputLine.IndexOf(","));
    showCountRowLn = showCountRowLn.Substring(0, +1);

    string showCountColumnLn = inputLine.Substring(inputLine.IndexOf(",") + 1);
    showCountColumnLn = showCountColumnLn.Substring(0, +1);

    int showCountRow = int.Parse(showCountRowLn);
    int showCountColumn = int.Parse(showCountColumnLn);


    int i = showCountRow; int j = showCountColumn;

    if ((i < (mas.GetLength(0)))
        && (j < (mas.GetLength(1)))
        && (i >= 0)
        && (j >= 0))
    {
        Console.Write("Элемент на позиции ");
        // Выделяю цветом, потому что я могу это сделать)))
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("[" + showCountRow + "," + showCountColumn + "]" + " ");
        Console.ResetColor();
        Console.Write(" - ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(mas[i, j]);
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("В массиве нет такого элемента");
        Console.ResetColor();

    }
}

int[,] twoDimArray = FillTwoDimArray(5, 5);
PrintTwoDimArray(twoDimArray);
ShowValue(twoDimArray);