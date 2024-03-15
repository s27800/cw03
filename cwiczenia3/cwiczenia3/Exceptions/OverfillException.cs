namespace cwiczenia3.Exceptions;

public class OverfillException : Exception
{
    public OverfillException(string message)
    {
        Console.WriteLine(message);
    }
}