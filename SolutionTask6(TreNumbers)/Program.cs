Console.Clear();
Console.WriteLine("TreNumbers"); //Программа, которая принимает на вход три числа, и выдает максимальное из этих чисел
Console.WriteLine("Welcome!");
Console.WriteLine("Enter the first number");
string? inputData1 = Console.ReadLine();
Console.WriteLine("Enter the second number");
string? inputData2 = Console.ReadLine();
Console.WriteLine("Enter the third number");
string? inputData3 = Console.ReadLine();

if ((inputData1 != null) && (inputData2 != null) && (inputData3 != null))
{
    int num0 = int.Parse(inputData1);
    int num1 = int.Parse(inputData2);
    int num2 = int.Parse(inputData3);
    int max = num0;
    if ((max > num1) && (max > num2))
    {
        Console.Write("max = ");
        Console.WriteLine(max);
    }
    else
    {
        max = num1;

        if (max > num2)
        {
            Console.Write("max = ");
            Console.WriteLine(max);
        }
        else
        {
            max = num2;
            Console.Write("max = ");
            Console.WriteLine(max);
        }
    }









}

