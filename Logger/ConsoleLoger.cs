namespace Loger;

public class ConsoleLoger : ILoger
{
    public void LogError(string message)
    {
        Console.WriteLine(message);
    }
    
    public void LogInfo(string message)
    {
        Console.WriteLine(message);
    }
}