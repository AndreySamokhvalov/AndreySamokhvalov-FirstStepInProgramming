Console.Clear();

//метод считывания данных от пользователя
int ReadData()
{
    Console.WriteLine("Задайте число: ");
    return int.Parse(Console.ReadLine());
}

// метод печати
int NuturalNumberPrinter(int num)
{
    if(num == 2 )return 1;
    else
    {
        num--;
        Console.WriteLine(num);
        Console.Write(NuturalNumberPrinter(num) + " ");
    }
    return num;
}


int inputNumber = ReadData();
NuturalNumberPrinter(inputNumber+2);