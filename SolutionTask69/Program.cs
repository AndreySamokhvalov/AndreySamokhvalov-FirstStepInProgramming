Console.Clear();

int inputNumberA = ReadNumber("Введите число A: ");
int inputNumberB = ReadNumber("Введите число B: ");

Console.WriteLine(OriginPow(inputNumberA,inputNumberB));
Console.WriteLine(PowNumber(inputNumberA,inputNumberB));


int OriginPow(int a, int b)
{
    if (b == 2)
    {
        return a * a;
    }
    if (b == 1)
    {
        return a;
    }
    if (b % 2 == 0)
    {
        return OriginPow(a, b / 2) * OriginPow(a, b / 2);
    }
    else
    {
        return OriginPow(a, b / 2) * OriginPow(a, (b / 2) + 1);
    }
}


int PowNumber(int a, int b)
{
    if (b == 1) return a;
    return a * PowNumber(a, --b);
}

//метод считывания данных от пользователя
int ReadNumber(string text)
{
    Console.Write(text);
    return int.Parse(Console.ReadLine() ?? "");
}
