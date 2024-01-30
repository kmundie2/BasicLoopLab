int correctCode = 13579;
int userInput;
int attempts = 0;

while (attempts < 5)
{
    Console.WriteLine("Please enter code: ");
    userInput = int.Parse(Console.ReadLine());
    if (userInput == correctCode)
    {
        break;
    }
    else
    {
        Console.WriteLine("Incorrect code. Please try again.");
        attempts++;
    }
    if (userInput == correctCode)
    {
        Console.WriteLine("Valid Code. Welcome in!");
    }
}

Console.WriteLine("Too many incorrect attempts. Access denied.");
