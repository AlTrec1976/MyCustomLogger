namespace Loger;

public class FileLoger : ILoger
{
    private const string FILE_PATH = "D:\\TempLogs\\log.txt";
    public void LogError(string message)
    {
        using (StreamWriter sw = new StreamWriter(FILE_PATH, true))
        {
            sw.WriteLine($"[{DateTimeOffset.Now}] ERROR message: {message}");
        }
    }
    
    public void LogInfo(string message)
    {
        using (StreamWriter sw = new StreamWriter(FILE_PATH, true))
        {
            sw.WriteLine($"[{DateTimeOffset.Now}] INFO message: {message}");
        }
    }
}