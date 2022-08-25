Console.Clear();
int numberM = ReadData("Задайте число M");
int numberN = ReadData("Задайте число N");

if (numberM < numberN)
{
    NaturalNamberPrinter(numberM, numberN);
}
else
{
    NaturalNamberPrinter(numberN, numberM);
}

//метод считывания данных от пользователя
int ReadData(string line)
{
    Console.WriteLine(line);
    return int.Parse(Console.ReadLine());
}

// метод для печати
void NaturalNamberPrinter(int m, int n)
{
    if (m - 1 == n) return;
    Console.Write(m + " ");
    NaturalNamberPrinter(m + 1, n);
}
