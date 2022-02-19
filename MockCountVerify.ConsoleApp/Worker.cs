namespace MockCountVerify.ConsoleApp;

internal class Worker
{
    private readonly ILogger _logger;

    internal Worker(ILogger logger)
    {
        ArgumentNullException.ThrowIfNull(logger, nameof(logger));

        _logger = logger;
    }

    internal void DoWork()
    {
        for (int i = 1; i <= 10; i++)
        {
            _logger.Log($"Loop counter {i}");
        }
    }
}
