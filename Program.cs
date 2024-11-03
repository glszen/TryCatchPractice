Start:
try 
{
    Console.Write("Please enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int square = number * number;

    Console.WriteLine("Square in number is: " + square);

}
catch (FormatException) //Error type specified, if the user enters an incorrect format they will encounter an error
{
    Console.WriteLine("Error! Please enter a valid number."); 
    goto Start; //Reverted to receive new input from the user
}
