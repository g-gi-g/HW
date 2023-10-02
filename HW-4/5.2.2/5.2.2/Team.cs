using System.Diagnostics.Metrics;
using System.Text;

namespace Program
{
    class Team
    {
        private List<Worker> WorkerList;

        private readonly string Name;
        public Team(string name) 
        {
            Name = name;

            WorkerList = new List<Worker>();
        }
        
        public void AddMember(Worker worker) 
        {
            WorkerList.Add(worker);
        }

        public void WorkADay()
        { 
            foreach(Worker worker in WorkerList) 
            { 
                worker.FillWorkDay(); 
            }
        }
        public string GetInfo() 
        {

            StringBuilder result = new();

            result.AppendLine($"Team name: {Name}");

            int counter = 1;
            foreach(Worker worker in WorkerList) 
            {
                result.AppendLine($"{counter++}. {worker.Name}");
            }

            return result.ToString();
        }

        public string GetDetailedInfo() 
        {
            StringBuilder result = new();

            result.AppendLine($"Team name: {Name}");

            int counter = 1;
            foreach (Worker worker in WorkerList)
            {
                result.AppendLine($"{counter++}. {worker.Name} - {worker.Position} - {worker.WorkDay}");
            }

            return result.ToString();
        }
    
    }

}