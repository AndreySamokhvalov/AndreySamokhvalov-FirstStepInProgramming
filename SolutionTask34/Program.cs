//Метод возвращает массив заполненый случайными числами 
int[] FillingArray()
{
    int[] outArray = new int[123];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 123)
    {
        outArray[i] = numberSintezator.Next(100, 1000);
        i++;
    }
    return outArray;
}

//Метод печатает массив
void PrintIntArray(int[] inputArray)
{
    //Буфферная переменная
    int i = 0;
    Console.WriteLine("Заданный массив: ");
    //Пробегаем все элементы массива
    while (i < inputArray.Length - 1)
    {
        //Выводим элемент массива
        Console.Write(inputArray[i] + ", ");
        //Увеличиваем инкремент
        i++;
    }
    //Выводим элемент массива
    Console.WriteLine(inputArray[i]);
}

int CountEven(int[] CountEvenArray) // метод, считающий количество четных членов созданного массива
{
    int b = 0;  // переменная для накопления
    int i = 0;
    while (i < CountEvenArray.Length)
    {
        if (CountEvenArray[i] % 2 == 0)
        {
            b++;
        }
        i++;
    }
   return b;
}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.Write("Количество нечетных членов массива = ");
Console.WriteLine(CountEven(buferArray));





