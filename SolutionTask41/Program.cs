Console.Clear();
Console.WriteLine("GreaterThanZero"); //Программа,в которой пользователь вводит с клавиатуры M чисел, и программа считает, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Welcome!");
Console.WriteLine("Введите количество чисел, которые Вы планируете вводить");
int m = int.Parse(Console.ReadLine()); 

int[] Read(int m) //метод, для создания и заполнения массива с клавиатуры 
{

    int i = 0;
    int[] outArray = new int[m];
    while (i < m)
    {
        Console.WriteLine("Введите " + (i + 1) + "-ое число");
        outArray[i] = int.Parse(Console.ReadLine());
        i++;
    }
    return outArray;
}


void PrintIntArray(int[] inputArray) // метод выводящий масив на экран
{
    int i = 0;
    Console.WriteLine("Вы ввели числа: ");
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


int Calc(int[] inputNum) // МЕТОД, ВЫЧИСЛЯЮЩИЙ, ЯВЛЯИТСЯ ЛИ ВВЕДЕННОЕ ЧИСЛО БОЛЬШЕ НУЛЯ
{
    int b = 0; // переменная для накопления
    int i = 0;
    while (i < inputNum.Length)
    {
        if (inputNum[i] > 0)
        {
            b++;
        }
        i++;

    }
    return b;
}


int[] buferArray = Read(m);
PrintIntArray(buferArray);
Console.Write("количество чисел больше «0» = ");
Console.WriteLine(Calc(buferArray));


