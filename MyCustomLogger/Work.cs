using Loger;

namespace MyCustomLogger;

public class Work
{
    private readonly ILoger _loger;

    public Work(ILoger loger)
    {
        _loger = loger;
    }

    public void SomeWork()
    {
        _loger.LogInfo("Я работаю");
    }
}
