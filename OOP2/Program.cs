Car bmw = new Car(240);
Motorcycle kawasaki = new Motorcycle(400);
Dog Fido = new Dog("mieszaniec");
Fido.MakeSound(Fido.Race);
Cat ben = new Cat("brytyjski");
ben.MakeSound(ben.Race);
bmw.DisplayMaxSpeed(bmw.MaxSpeed);
kawasaki.DisplayMaxSpeed(kawasaki.MaxSpeed);

public class Vehicle(int maxspeed)
{
    public int MaxSpeed = maxspeed;

    public void DisplayMaxSpeed(int maxspeed)
    {
        Console.WriteLine($"{this.GetType()} {maxspeed}");
    }
}

public class Car(int maxspeed) : Vehicle(maxspeed);
public class Motorcycle(int maxspeed):Vehicle(maxspeed);


abstract public class Animal(string race)
{
    public string Race = race;
    abstract public void MakeSound(string race);
}

public class Dog(string race) : Animal(race)
{
    public override void MakeSound(string race)
    {
        Console.WriteLine($"{this.GetType()} makes woof woof"); ;
    }
}
public class Cat(string race) : Animal(race)
{
    public override void MakeSound(string race)
    {
        Console.WriteLine($"{this.GetType()} makes meow meow"); ;
    }
}