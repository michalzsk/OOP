Human Ewok = new Human("Ewok", 19);
Ewok.Eat("gowno");
Student Ewoczek = new Student("Ewok", 69);
Ewoczek.Learn("meth");
Ewoczek.Eat("Marchewka");
Employee Ejwon = new Employee("Ewok", 420);
Ejwon.Work("Ksieżyc planety endor");
class Human(string name, int age)
{
    public int Age = age;
    public string Name = name;

    public void Eat(string food)
    {
        Console.WriteLine($"{Name} eats: {food}");
    }
}
class Employee(string name, int age) : Human(name, age)
{
    public void Work(string WorkPlace)
    {
        Console.WriteLine($"{name} works in: {WorkPlace}");
    }
}
class Student(string name, int age) : Human(name, age)
{
    public int Age = age;
    public string Name = name;
    public void Learn(string subject)
    {
        Console.WriteLine($"{Name} learns: {subject}");
    }
}