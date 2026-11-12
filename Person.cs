namespace Task_2_IEEE
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void Introduce()
        {
            Console.WriteLine($"\nHi, I am {Name}, {Age} years old.");
        }
    }

 

}
