
string? inputLineN = Console.ReadLine();

if(inputLineN != null)
{
    int numberN = int.Parse(inputLineN);

    //int outNumber = inputNumber*inputNumber;
    int outNumber = (int)Math.Pow(numberN,2);
    string lineN = "";
    string lineNN = "";
    int start = 1;

while (start<numberN)
{
   lineN=lineN+start+" ";
   lineNN=lineNN+(start*start)+" ";
   start++;
}
    Console.WriteLine(lineN);
    Console.WriteLine(lineNN);
}

// кирилл
// List<int> listGen(int number) {
//     List<int> numbers = new List<int>();
//     for(int i = 1; i <= number; i++){
//         numbers.Add(i);
//     }
//     return numbers;
// }

// string? inputLine = Console.ReadLine();

// if (inputLine != null) 
// {
//     int inputNumber = int.Parse(inputLine);
//     List<int> nums = listGen(inputNumber);
//     foreach (var i in nums) {
//         Console.Write(i);
//         Console.Write(" ");
//     }  
//     Console.WriteLine();
//     foreach (var i in nums) {
//         Console.Write(Math.Pow(i, 2));
//         Console.Write(" ");
//     }
// }
