// int diget1;
// int diget2;
// int diget3;
// int diget4;
// int diget5;
// int inputNumber;

// void calculation()
// {
//     diget1 = inputNumber / 10000; // вычисляем значения цифр с 1 по 5
//     diget2 = (inputNumber / 1000) % 10;
//     diget3 = (inputNumber / 100) % 10;
//     diget4 = (inputNumber / 10) % 10;
//     diget5 = inputNumber % 10;
// }

// void solution()
// {
//     if (diget1 == diget5 && diget2 == diget4) // проверяем, является ли число палиндромом
//     {
//         Console.Write(inputNumber);
//         Console.WriteLine(" - это палиндром");
//     }
//     else
//     {
//         Console.Write(inputNumber);
//         Console.WriteLine(" - это не палиндром");
//     }
// }


// Console.Clear();
// Console.WriteLine("Palindrom"); //Программа,  которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Console.WriteLine("Welcome!");
// Console.WriteLine("Введите пятизначное число");
// inputNumber = int.Parse(Console.ReadLine());
// if ((inputNumber > 9999) && (inputNumber < 100000)) // проверяем условие, является ли вводимое число пятизначным
// {
//     calculation();
//     solution();
// }
// else
// {
//     Console.WriteLine("Вводимое число не пятизначное");
// }



// // Решение через словарь
Dictionary<int, string> Palindrom = new Dictionary<int, string>(); // создаем словарь палиндромов
Palindrom.Add(1111, "Палиндром");
Palindrom.Add(1221, "Палиндром");
Palindrom.Add(1331, "Палиндром");
Palindrom.Add(1441, "Палиндром");
Palindrom.Add(1551, "Палиндром");
Palindrom.Add(1661, "Палиндром");
Palindrom.Add(1771, "Палиндром");
Palindrom.Add(1881, "Палиндром");
Palindrom.Add(1991, "Палиндром");
Palindrom.Add(2112, "Палиндром");
Palindrom.Add(2222, "Палиндром");
Palindrom.Add(2332, "Палиндром");
Palindrom.Add(2442, "Палиндром");
Palindrom.Add(2552, "Палиндром");
Palindrom.Add(2662, "Палиндром");
Palindrom.Add(2772, "Палиндром");
Palindrom.Add(2882, "Палиндром");
Palindrom.Add(2992, "Палиндром");
Palindrom.Add(3113, "Палиндром");
Palindrom.Add(3223, "Палиндром");
Palindrom.Add(3333, "Палиндром");
Palindrom.Add(3443, "Палиндром");
Palindrom.Add(3553, "Палиндром");
Palindrom.Add(3663, "Палиндром");
Palindrom.Add(3773, "Палиндром");
Palindrom.Add(3883, "Палиндром");
Palindrom.Add(3993, "Палиндром");
Palindrom.Add(4114, "Палиндром");
Palindrom.Add(4224, "Палиндром");
Palindrom.Add(4334, "Палиндром");
Palindrom.Add(4444, "Палиндром");
Palindrom.Add(4554, "Палиндром");
Palindrom.Add(4664, "Палиндром");
Palindrom.Add(4774, "Палиндром");
Palindrom.Add(4884, "Палиндром");
Palindrom.Add(4994, "Палиндром");
Palindrom.Add(5115, "Палиндром");
Palindrom.Add(5225, "Палиндром");
Palindrom.Add(5335, "Палиндром");
Palindrom.Add(5445, "Палиндром");
Palindrom.Add(5555, "Палиндром");
Palindrom.Add(5665, "Палиндром");
Palindrom.Add(5775, "Палиндром");
Palindrom.Add(5885, "Палиндром");
Palindrom.Add(5995, "Палиндром");
Palindrom.Add(6116, "Палиндром");
Palindrom.Add(6226, "Палиндром");
Palindrom.Add(6336, "Палиндром");
Palindrom.Add(6446, "Палиндром");
Palindrom.Add(6556, "Палиндром");
Palindrom.Add(6666, "Палиндром");
Palindrom.Add(6776, "Палиндром");
Palindrom.Add(6886, "Палиндром");
Palindrom.Add(6996, "Палиндром");
Palindrom.Add(7117, "Палиндром");
Palindrom.Add(7227, "Палиндром");
Palindrom.Add(7337, "Палиндром");
Palindrom.Add(7447, "Палиндром");
Palindrom.Add(7557, "Палиндром");
Palindrom.Add(7667, "Палиндром");
Palindrom.Add(7777, "Палиндром");
Palindrom.Add(7887, "Палиндром");
Palindrom.Add(7997, "Палиндром");
Palindrom.Add(8118, "Палиндром");
Palindrom.Add(8228, "Палиндром");
Palindrom.Add(8338, "Палиндром");
Palindrom.Add(8448, "Палиндром");
Palindrom.Add(8558, "Палиндром");
Palindrom.Add(8668, "Палиндром");
Palindrom.Add(8778, "Палиндром");
Palindrom.Add(8888, "Палиндром");
Palindrom.Add(8998, "Палиндром");
Palindrom.Add(9119, "Палиндром");
Palindrom.Add(9229, "Палиндром");
Palindrom.Add(9339, "Палиндром");
Palindrom.Add(9449, "Палиндром");
Palindrom.Add(9559, "Палиндром");
Palindrom.Add(9669, "Палиндром");
Palindrom.Add(9779, "Палиндром");
Palindrom.Add(9889, "Палиндром");
Palindrom.Add(9999, "Палиндром");
Palindrom.Add(1001, "Палиндром");
Palindrom.Add(2002, "Палиндром");
Palindrom.Add(3003, "Палиндром");
Palindrom.Add(4004, "Палиндром");
Palindrom.Add(5005, "Палиндром");
Palindrom.Add(6006, "Палиндром");
Palindrom.Add(7007, "Палиндром");
Palindrom.Add(8008, "Палиндром");
Palindrom.Add(9009, "Палиндром");

Console.Clear();
Console.WriteLine("Palindrom"); //Программа,  которая принимает на вход четырехзначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Welcome!");
Console.WriteLine("Введите четырехзначное число");
int A = int.Parse(Console.ReadLine());
if (Palindrom.ContainsKey(A) == true) // проверяем, содержит ли словарь указаннй ключ
{
    Console.Write(A);
    Console.WriteLine(" - это четырехзначный палиндром");
}

else
{
    Console.Write(A);
    Console.WriteLine(" - это не четырехзначный палиндром");
}