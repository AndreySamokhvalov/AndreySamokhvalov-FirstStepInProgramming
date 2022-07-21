Console.Clear();
Console.WriteLine("Chetnost"); //Программа, колторая на ввод принимает число, и проверяет, является ли оно четным
Console.WriteLine("Welcome!");
Console.WriteLine("Enter your number");
string? inputData = Console.ReadLine();
if (inputData != null)
{
    int num0 = int.Parse(inputData);
    int div = num0 % 2;
    if (div == 0)
    {
        Console.WriteLine("This number is even");
    }
    else
    {
        Console.WriteLine("This number is not even");
    }
}

