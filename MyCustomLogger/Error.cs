using Loger;

namespace MyCustomLogger;

public class Error
{
    private readonly ILoger _loger;

    public Error(ILoger loger)
    {
        _loger = loger;
    }

    public void SomeWork()
    {
        _loger.LogError("Совершена ошибка");
    }
}