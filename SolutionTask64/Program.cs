//Программа, принимающая на вход число N
//и выдающая натуральные числа от N до 1
Console.Clear();
Console.WriteLine("FromNtoOne");
Console.WriteLine("Welcome!");

int numN = ReadData();
NuturalNumberPrinter(numN);

//метод получения данных от пользователя
int ReadData()
{
    Console.WriteLine("Введите число N: ");
    return int.Parse(Console.ReadLine());
}

// метод печати чисел от 1 до N
int NuturalNumberPrinter(int N)
{
    if (N == 1)
    {
        Console.Write(1);
        return 1;
    }
    else
    {
        Console.Write(N + " ");
        N = NuturalNumberPrinter(N - 1);
        return N;
    }
}