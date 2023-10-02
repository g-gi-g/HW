namespace Program
{
    class Manager : Worker
    {
        private Random RandVar;
        public Manager(string name)
            : base(name)
        {
            Position += "Менеджер";

            RandVar = new Random();
        }

        public override void FillWorkDay()
        {
            int numOfCalls = RandVar.Next(1, 11);

            for (int i = 0; i < numOfCalls; i++) 
            {
                Call();
            }

            Relax();

            numOfCalls = RandVar.Next(1, 6);

            for (int i = 0; i < numOfCalls; i++) 
            {
                Call();
            }
        }
    }
}