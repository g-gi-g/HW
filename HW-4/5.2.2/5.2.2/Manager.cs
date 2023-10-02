namespace Program;

class Manager : Worker
{
    private Random randVar;

    public Manager(string name)
        : base(name)
    {
        Position = "Менеджер";

        randVar = new Random();
    }

    public override void FillWorkDay()
    {
        int numOfCalls = randVar.Next(1, 11);

        for (int i = 0; i < numOfCalls; i++) 
        {
            Call();
        }

        Relax();

        numOfCalls = randVar.Next(1, 6);

        for (int i = 0; i < numOfCalls; i++) 
        {
            Call();
        }
    }
}