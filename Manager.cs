namespace Task_2_IEEE
{
    class Manager : Employee
    {
        public List<Developer> Team { get; set; } = new List<Developer>();

        public Manager(string name, int age, int id, decimal salary)
            : base(name, age, id, salary)
        {
        }

        public void AddToTeam(Developer developer)
        {
            Team.Add(developer);
        }

        public void ShowTeam()
        {
            foreach (Developer developer in Team)
            {
                developer.Introduce();
            }
        }

        public override void Introduce()
        {
            base.Introduce();

            Console.WriteLine($"I am a Manager and I lead {Team.Count} developers.");
        }
    }

 

}
