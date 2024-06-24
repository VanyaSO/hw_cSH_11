namespace Task_1;

public delegate void MessageDelegate(string message);
public static class Message
{
    public static void SuccessMessage(string mess)
    {
        Console.WriteLine($"Success: {mess}");
    }
    
    public static void WarningMessage(string mess)
    {
        Console.WriteLine($"Warning: {mess}");
    }
    
    public static void ErrorMessage(string mess)
    {
        Console.WriteLine($"Error: {mess}");
    }
}