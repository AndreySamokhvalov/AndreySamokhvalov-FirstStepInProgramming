Console.Clear();
Console.WriteLine("AckermannFunc");
Console.WriteLine("Welcome!");

int numM = ReadData("задайте число М: ");
int numN = ReadData("задайте число N: ");
Console.WriteLine();

Console.Write("А(" + numM + "," + numN + ") = " + AckermannFunc(numM, numN));

// метод получения данных от пользователя
int ReadData(string data)
{
    Console.WriteLine();
    Console.WriteLine(data);
    return int.Parse(Console.ReadLine());
}

// метод вычисления функции Акерманна
int AckermannFunc(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return AckermannFunc(m - 1, 1);
    else return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
}

