string textToParseAsInt;
int indexToAccess;
string message;

Console.WriteLine("Enter text to parse as an int: ");
textToParseAsInt = Console.ReadLine();
Console.WriteLine("Enter a number for the index to access: ");
indexToAccess = int.Parse(Console.ReadLine());

message = HandleMultipleExceptions(textToParseAsInt, indexToAccess);
Console.WriteLine(message);

string HandleMultipleExceptions(string textToParseAsInt, int indexToAccess) {
    int[] numbers = { 1, 2, 3 };
    try
    {
        int parsedInt = int.Parse(textToParseAsInt);
        int numberFromArray = numbers[indexToAccess];
        return numberFromArray.ToString();
    }
    catch (FormatException ex) 
    {
        return "Invalid format";
    }
    catch (IndexOutOfRangeException ex)
    {
        return "Index out of range";
    }
}