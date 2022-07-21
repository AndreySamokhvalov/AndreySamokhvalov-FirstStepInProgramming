//Метод решения задачи №13 вариант №1 
void var1(string? inputData)
{
 if (inputData != null)
    {
        Char[] inputNum = inputData.ToCharArray(); // перевожу в массив
        if (inputNum.Length >= 3) // условия для вывода третьей цифры
        {
            Console.WriteLine(inputNum[2]);
        }
        else
        {
            Console.WriteLine("третьей цифры нет");
        }
    }
}

Console.Clear();
Console.WriteLine("ThridNumber"); //Программ, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Welcome!");
Console.WriteLine("Введите число");
string? inputData = Console.ReadLine();

var1(inputData);