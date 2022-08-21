// Программа, которая будет построчно выводить массив,
// добавляя индексы каждого элемента
//-----------------------------------------------------

// получение данных от пользователя
int[] ReadData()
{
    Console.Clear();
    Console.WriteLine("PrintRow3DArray");
    Console.WriteLine("Welcome!");
    Console.WriteLine();
    Console.Write("Задайте первую размерность массива ");
    int first = int.Parse(Console.ReadLine());
    Console.Write("Задайте вторую размерность массива ");
    int secons = int.Parse(Console.ReadLine());
    Console.Write("Задайте третью размерность массива ");
    int third = int.Parse(Console.ReadLine());
    int[] data = new int[] { first, secons, third };
    return data;
}

// метод, создающий рандомный трехмерный массив с указаными параметрами
int[,,] Fill3DArray(int[] data)
{
    int firstMetering = data[0]; int secondMetering = data[1]; int thirdMetering = data[2];
    System.Random numberSyntezator = new System.Random();
    int i = 0; int j = 0; int k = 0;
    List<int> numbers = new List<int>();
    int[,,] outArray = new int[firstMetering, secondMetering, thirdMetering];


    while (i < firstMetering)
    {
        j = 0;
        while (j < secondMetering)
        {
            k = 0;
            while (k < thirdMetering)
            {
                int buf = numberSyntezator.Next(10, 100);

                if (numbers.Contains(buf))
                {
                    continue;
                }
                else
                {
                    outArray[i, j, k] = buf;
                }
                numbers.Add(buf);
                k++;
            }
            j++;
        }
        i++;
    }
    return outArray;
}

//метод для печати трехмерного массива по строкам
void PrintTwoDimArray(int[,,] inputArray)
{
    int i = 0; int j = 0; int k = 0;
    Console.WriteLine();
    while (i < inputArray.GetLength(0))
    {
        j = 0;
        // заменив равенство на закомментированное неравенство
        // получим метод печати 3D ассива
        while (j == 0)//< inputArray.GetLength(1))
        {
            k = 0;
            while (k < inputArray.GetLength(2))
            {
                Console.Write(inputArray[i, j, k] + "(" + i + j + k + ")" + "   ");
                k++;
            }
            Console.Write("\n");
            Console.WriteLine();
            j++;
        }
        i++;
    }

}

int[] inputData = ReadData();
Fill3DArray(inputData);
int[,,] threeDimArray = Fill3DArray(inputData);
PrintTwoDimArray(threeDimArray);
