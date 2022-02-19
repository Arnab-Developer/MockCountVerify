using static System.Console;

namespace MockCountVerify.ConsoleApp;

internal class Logger : ILogger
{
    void ILogger.Log(string message)
    {
        WriteLine(message);
    }
}