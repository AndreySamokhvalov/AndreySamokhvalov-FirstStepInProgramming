// Программа, которая спирально заполняет массив
//---------------------------------------------

// получение данных от пользователя
int[] ReadData()
{
    Console.Clear();
    Console.WriteLine("SpiralArray");
    Console.WriteLine("Welcome!");
    Console.WriteLine();
    Console.Write("Задайте количество строк: ");
    int row = int.Parse(Console.ReadLine());
    Console.Write("Задайте количество столбцов: ");
    int column = int.Parse(Console.ReadLine());
    int[] data = new int[] { row, column };
    return data;
}

//метод для спирального заполнения рандомного массива
int[,] FillSpiralTwoDimArray(int[] data)
{
    int countRowrow = data[0]; int countColumn = data[1];
    int[,] spiralArray = new int[countRowrow, countColumn];

    int num = 1;
    int i = 0;
    int j = 0;

    while (num <= (spiralArray.GetLength(0) * spiralArray.GetLength(1)))
    {
        spiralArray[i, j] = num;

        if ((i <= j + 1) && (i + j < spiralArray.GetLength(1) - 1))
        {
            j++;
        }
        else
        {
            if ((i < j) && (i + j >= spiralArray.GetLength(0) - 1))
            {
                i++;
            }
            else
            {
                if ((i >= j) && (i + j > spiralArray.GetLength(1) - 1))
                {
                    j--;
                }
                else
                {
                    i--;
                }
            }
        }
        num++;
    }
    return spiralArray;
}

//выводит двухмерный массив
void PrintTwoDimArray(int[,] array)
{
    Console.WriteLine("Вот Ваш спиральный массив:");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[] inputData = ReadData();
int[,] bufSpiralArray = FillSpiralTwoDimArray(inputData);
PrintTwoDimArray(bufSpiralArray);