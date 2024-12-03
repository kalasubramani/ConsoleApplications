// See https://aka.ms/new-console-template for more information
Console.WriteLine("Press ESC to exit");
Console.WriteLine("How many numbers would you like to sum");

string n= Console.ReadLine();
int sum = 0,i=0;
List<int> numberList = new List<int>();
string input;

//do
//{
//    Console.WriteLine("Enter a number to sum");
//    input = Console.ReadLine();
//    numberList.Add(int.Parse(input));

//}while (Console.ReadKey().Key != ConsoleKey.Escape);

while (i < Int32.Parse(n))
{
    Console.WriteLine("Enter a number to sum");

    //add a check to see of the input is an integer
    input = Console.ReadLine();

    if (!int.TryParse(input, out int output))
    {
        Console.WriteLine("Not an integer. Please enter an integer to sum");
        input = Console.ReadLine();
    }

    int temp = Int32.Parse(input);
    numberList.Add(temp);
    sum += temp;

    i++;
}

//find max
Console.WriteLine("Max value: " + numberList.Max());
Console.WriteLine("Min value: " + numberList.Min());

int length = Int32.Parse(n); //covert n to int
Console.WriteLine("Average of numbers: " + sum / length);


Console.WriteLine("sum" + sum);



