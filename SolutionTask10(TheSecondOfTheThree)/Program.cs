// метод решения задачи №10. Вариант № 1
void var1(string? inputData)
{
    if (inputData != null)
    {
        int num0 = int.Parse(inputData);
        int st1 = (num0 % 100) / 10; // отбрасывание первой и последней цифры
        if (((num0 > -1000) && (num0 < -99)) || ((num0 > 99) && (num0 < 1000))) // проверка, является ли вводимое чило трехзначным
        {
            Console.WriteLine(Math.Abs(st1));
        }
        else
        {
            Console.Write(inputData);
            Console.WriteLine(" - число не трехзначное");
        }
    }

}

//метод решения задачи №10. Вариант № 1
void var2(string? inputData)
{
    {
        if (inputData != null)
        {
            Char[] inputNum = inputData.ToCharArray();
            if ((inputNum.Length == 3) && (inputData[0] > 0)) // проверка, является ли вводимое чило трехзначным
            {
                Console.WriteLine(inputNum[1]);
            }
            else 
                Console.WriteLine(inputNum[2]);
        }
    }
}




Console.Clear();
Console.WriteLine("TheSecondOfTheThree"); //Программа, которая на вход принимает трехзначное число, а на выходе показывает вторую цифру этого числа
Console.WriteLine("Welcome!");
Console.WriteLine("Введите трехзначное число");
string? inputData = Console.ReadLine();

var1(inputData);
var2(inputData);


