Console.Clear();
Console.WriteLine("TwoNumbers"); //Программа, которая на ввод принимает два числа и выдает какое число большее, а какое меньшее
Console.WriteLine("Welcome!");
Console.WriteLine("Enter the first number");
string? inputData1 = Console.ReadLine();
Console.WriteLine("Enter the second number");
string? inputData2 = Console.ReadLine();

if ((inputData1 != null)&&(inputData2 != null))
    {
        int num0 = int.Parse(inputData1);
        int num1 = int.Parse(inputData2);
        if (num0 > num1)
        {
            Console.Write("max = ");
            Console.WriteLine(num0);
            Console.Write("min = ");
            Console.WriteLine(num1);
        }
        
        else
        {
            Console.Write("max = ");
            Console.WriteLine(num1);
            Console.Write("min = ");
            Console.WriteLine(num0);
        }

    };


