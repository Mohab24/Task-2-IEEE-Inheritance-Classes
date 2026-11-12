namespace Task_2_IEEE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("Sara", 35, 1, 10000);

            Developer dev1 = new Developer("Omar", 24, 2, 8000, "C#");
            Developer dev2 = new Developer("Ali", 26, 3, 9000, "Java");

            manager.AddToTeam(dev1);
            manager.AddToTeam(dev2);

            manager.Introduce();

            dev1.Introduce();
            dev2.Introduce();

            manager.RaiseSalary(10);
            dev1.RaiseSalary(10);
            dev2.RaiseSalary(10);

            Console.WriteLine($"\nSalary after raise: {manager.Salary:F2}");



            Console.ReadKey();
        }
    }

 

}
