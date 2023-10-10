using BracketPoc;

Console.Write("Enter string arguments: ");
var arguments = Console.ReadLine();

if (string.IsNullOrEmpty(arguments))
{
    return;
}

var result = Bracket.Check(arguments);
Console.WriteLine($"The result is: {result}");