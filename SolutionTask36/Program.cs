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

int Colculate(int[] sumArray)
{
    int b = 0;  // переменная для накопления
    int i = 1;
    while (i < sumArray.Length)
    {
        b = b + sumArray[i];
        i += 2;
    }
    return b;
}

int[] buferArray = FillingArray();
PrintIntArray(buferArray);
Console.Write("Cумма элементов, стоящих на нечётных позициях = ");
Console.WriteLine(Colculate(buferArray));





