Console.Clear();
Console.WriteLine("ChetniyDoN"); //Программа, которая на ввод принимает (N), а на выходе показывает все четные числа от 1 до N
Console.WriteLine("Welcome!");
Console.WriteLine("Enter your number");
string? inputData = Console.ReadLine();

if (inputData != null)
{
    int inputNumber = int.Parse(inputData);
    int B = 2;
    string outLine = "";
    while (B <= inputNumber-2) // включая вводимое число, если оно четное (как в примере)
       {   
         outLine = (outLine + B + ", ");
         B = B + 2;    
        }
        Console.WriteLine(outLine+B);
      
}
       
       
