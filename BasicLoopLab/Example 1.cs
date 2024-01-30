bool continueLoop = false;
do
{
    Console.WriteLine("Hello, World!");
    Console.WriteLine("Would you like to continue? (y/n): ");
    string input = Console.ReadLine();
    continueLoop = input.ToLower() == "y";
} while (continueLoop);
Console.WriteLine("Goodbye.");