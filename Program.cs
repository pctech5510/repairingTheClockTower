// See https://aka.ms/new-console-template for more information
// Take a number as input from the user
//Display the word Tick if the number is even, and Tock if the number is odd
Console.Write("Please Enter a number from 1 to 12: ");
int number = Convert.ToInt32(Console.ReadLine());
int tickTock = number % 2;
if (number > 12)
    Console.Write("Did you enter a number between 1 and 12? Try again");

else if (tickTock == 0)
        Console.WriteLine("Tick");
   else
       Console.WriteLine("Tock");



