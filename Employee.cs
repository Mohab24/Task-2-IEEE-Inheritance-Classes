namespace Task_2_IEEE
{
    class Employee : Person
    {
        public int Id { get; set; }
        public decimal Salary { get; protected set; }

        public Employee(string name, int age, int id, decimal salary)
            : base(name, age)
        {
            Id = id;
            Salary = salary;
        }

        public void RaiseSalary(decimal percent)
        {
            Salary += Salary * percent / 100;
        }

        public override void Introduce()
        {
            base.Introduce();

            Console.WriteLine($"I work as an employee, ID = {Id}.");
        }
    }

 

}
