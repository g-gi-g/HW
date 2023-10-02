namespace Program;


abstract class Worker
{ 
    public string Name { get; }

    public string? Position { get; protected set; }

    public string WorkDay { get; private set; }

    public Worker(string name) 
    {
        Name = name;
        Position = null;
        WorkDay = string.Empty;
    }

    public void Call()
    {
        WorkDay += "Call ";
    }

    public void WriteCode()
    {
        WorkDay += "WriteCode ";
    }

    public void Relax() 
    {
        WorkDay += "Relax ";
    }

    public abstract void FillWorkDay();
}