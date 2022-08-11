//Метод возвращает массив заполненый случайными числами 
int[] FillingArray()
{
    int[] outArray = new int[100];
    int i = 0;
    System.Random numberSintezator = new System.Random();
    while (i < 100)
    {
        outArray[i] = numberSintezator.Next(1, 1000);
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

int Colculate(int[] randomArray) // метод выполняющий вычисления
{
    int max = 0;  // максимальное значение
    int min = int.MaxValue; // минимальное значение
    int i = 0;
    while (i < randomArray.Length)
    {
        if (randomArray[i] > max)
        {
            max = randomArray[i];
        }
        if (randomArray[i] < min)
        {
            min = randomArray[i];
        }
        i++;
    }

    return max - min; // искомая разница
}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.Write("Разница между максимальным и минимальным элементов массива = ");
Console.WriteLine(Colculate(buferArray));

