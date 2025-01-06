namespace design_patterns.Singleton.Logger.Solution;

public class Logger
{
    public static Logger Instance { get; } = new Logger();
    private string? _logs;

    private Logger()
    {
        Clear();
    }

    public string? GetLogs()
    {
        return _logs;
    }

    public void AddLog(string log)
    {
        _logs = $"{_logs} >>> {log}\n";
    }

    public void Clear()
    {
        _logs = DateTime.Now + "\n";
    }
}