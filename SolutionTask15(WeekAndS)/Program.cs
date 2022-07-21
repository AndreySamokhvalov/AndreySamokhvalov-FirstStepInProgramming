Console.Clear();
Console.WriteLine("TheSecondOfTheThree"); //Программа, которая на вход принимает трехзначное число, а на выходе показывает вторую цифру этого числа
Console.WriteLine("Welcome!");
Console.WriteLine("Введите номер дня недели");
string? inputData = Console.ReadLine();
{
    if (inputData != null)
    {
        int numDay = int.Parse(inputData);
        if ((numDay>=1)&&(numDay<=7))
        {
            if ((numDay==6)||(numDay==7))
            {
                Console.WriteLine("этот день выходной");
            }
            else
            {
               Console.WriteLine("этот день рабочий"); 
            }
        }
        else 
        {
            Console.WriteLine("в неделе 7 дней"); 
        }
    }
}