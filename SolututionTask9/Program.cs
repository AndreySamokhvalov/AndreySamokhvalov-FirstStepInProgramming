System.Random numberSintezator = new Random();
// метод решения 1
void var1(System.Random numberSintezator)
{
   int number = numberSintezator.Next(10,100);
   Console.WriteLine(number);
// вариант 1
int firstNumber = number/10;
int secondNumber = number%10;

if(firstNumber>secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
   Console.WriteLine(secondNumber);
}
 
}
// метод решения 2
void var2()
{
int number = new Random().Next(10, 100);
Console.Write("The random number is: ");
Console.WriteLine(number);
string stringNum = number.ToString();
Console.Write("The biggest digit is : ");
if (stringNum[0] > stringNum[1]){
    Console.WriteLine(stringNum[0]);
} else {
    Console.WriteLine(stringNum[1]);
}

}

//Вриант 3

// // метод решения 3
// {
// char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();
// Console.WriteLine(digits);
// int firstNumber = ((int)digits[0])-48;
// int secondNumber = ((int)digits[1])-48;
// int resultNumber = firstNumber > secondNumber ? resultNumber : resultNumber = secondNumber;

// Console.WriteLine(resultNumber);
// }



