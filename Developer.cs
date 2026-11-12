namespace Task_2_IEEE
{
    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, int age, int id,
                         decimal salary, string language)
            : base(name, age, id, salary)
        {
            ProgrammingLanguage = language;
        }

        public void Code()
        {
            Console.WriteLine($"I write {ProgrammingLanguage}.");
        }

        public override void Introduce()
        {
            base.Introduce();

            Console.WriteLine($"I am a Developer and I write {ProgrammingLanguage}.");
        }
    }

 

}
