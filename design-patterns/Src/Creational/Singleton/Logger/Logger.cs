namespace design_patterns.Creational.Singleton.Logger;

public class Logger
{
    private string? _logs;

    public Logger()
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