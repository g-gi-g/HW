using System.Text;

namespace Program;

class Team
{
    private readonly List<Worker> workerList;

    private readonly string name;

    public Team(string name) 
    {
        this.name = name;

        workerList = new List<Worker>();
    }
    
    public void AddMember(Worker worker) 
    {
        workerList.Add(worker);
    }

    public void WorkADay()
    { 
        foreach (var worker in workerList) 
        { 
            worker.FillWorkDay(); 
        }
    }

    public string GetInfo() 
    {
        StringBuilder result = new();

        result.AppendLine($"Ім'я команди: {name}");

        int counter = 1;
        foreach (var worker in workerList) 
        {
            result.AppendLine($"{counter++}. {worker.Name}");
        }

        return result.ToString();
    }

    public string GetDetailedInfo() 
    {
        StringBuilder result = new();

        result.AppendLine($"Ім'я команди: {name}");

        int counter = 1;
        foreach (var worker in workerList)
        {
            result.AppendLine($"{counter++}. {worker.Name} - {worker.Position} - {worker.WorkDay}");
        }

        return result.ToString();
    }

}