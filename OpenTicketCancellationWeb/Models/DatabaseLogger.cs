namespace OpenTicketCancellationWeb.Models
{
    //public class DatabaseLogger : ILogger
    //{
    //    private readonly Func<LoggingDbContext> _dbContextFactory;
    //    private readonly string _categoryName;

    //    public DatabaseLogger(Func<LoggingDbContext> dbContextFactory, string categoryName)
    //    {
    //        _dbContextFactory = dbContextFactory;
    //        _categoryName = categoryName;
    //    }

    //    public IDisposable BeginScope<TState>(TState state) => null;

    //    public bool IsEnabled(LogLevel logLevel) => true;

    //    public async void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
    //    {
    //        if (!IsEnabled(logLevel))
    //        {
    //            return;
    //        }

    //        var logEntry = new LogEntry
    //        {
    //            Timestamp = DateTime.UtcNow,
    //            LogLevel = logLevel,
    //            Message = formatter(state, exception),
    //            Exception = exception?.ToString()
    //        };

    //        using (var context = _dbContextFactory())
    //        {
    //            context.LogEntries.Add(logEntry);
    //            await context.SaveChangesAsync();
    //        }
    //    }
    //}
}