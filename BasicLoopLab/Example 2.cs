bool continueLoop = false;
do
{
    Console.WriteLine("Please enter a number: ");
    int number = int.Parse(Console.ReadLine());

    Console.WriteLine($"Counting down from {number} to 0:");
    for (int i = number; i >= 0; i--)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine($"Counting up from 0 to {number}:");
    for (int i = 0; i <= number; i++)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("Would you like to continue? (y/n): ");
    string input = Console.ReadLine();
    continueLoop = input.ToLower() == "y";
} while (continueLoop);
Console.WriteLine("Goodbye.");