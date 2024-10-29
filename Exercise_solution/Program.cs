
Book g1 = new Book("Ewok", "Michal Kluczynski", 69);
Book g2 = new Book("asd", "asd", 123);
g1.view();
g2.view();
Book g3 = new Book(null, null, 0);
g3.add();
g3.view();
BankAccount main = new BankAccount("Michal Kluczynski", 2000.45);
main.Deposit();
main.WithDraw();
main.DisplayBalance();

Food test = new Food("Hot Dog", 0);
test.ChangeIntoEnergy();

Dog piesek = new Dog("Fafik", 0);
piesek.Eat(test.EnergyGiven);
public class Book(string title, string author, int pages)
{
    public string title { get; private set; } = title;
    public string author { get; private set; } = author;
    public int pages { get; private set; } = pages;



    public void add()
    {
        this.title = "Cursed book";
        this.author = "anonim";
        this.pages = 2137;
    }
    public void view()
    {
        Console.WriteLine($"{this.title} {this.author} {this.pages} ");   
    }
}
public class BankAccount(string OwnerName, double Balance)
{
    public string OwnerName { get; set; } = OwnerName;
    public double Balance { get; private set; } = Balance;

    public void Deposit()
    {
        Console.WriteLine("Podaj kwote o ktora chcesz zasilic konto");
        double amount = int.Parse(Console.ReadLine());
        this.Balance = this.Balance + amount;
        Console.WriteLine($"Balans konta: {this.OwnerName} wynosi {this.Balance}");
    }
    public void WithDraw()
    {
        Console.WriteLine("Podaj kwote jaka chcesz wyplacic.");
        double amount = int.Parse(Console.ReadLine());
        if (this.Balance > amount)
        {
            this.Balance -= amount;
            Console.WriteLine($"Pieniadze wyplacono z konta. Aktualny stan konta: {this.Balance}");
        }
        else
        {
            Console.WriteLine($"Niewystarczajace srodki na koncie. Aktualny balans konta wynosi: {this.Balance}");
        }
    }
    public void DisplayBalance()
    {
        Console.WriteLine($"Twoje aktualne saldo konta wynosi: {this.Balance}");
    }
}
public class Food(string TypeName,int EnergyGiven)
{
    public string TypeName { private get; set; } = TypeName;
    public int EnergyGiven { get; set; } = EnergyGiven;
    public void ChangeIntoEnergy()
    {
        Random random = new Random();
        this.EnergyGiven = random.Next(6,10);
    }
}
public class Dog(string Name, int EnergyLvl)
{
    public string Name { get; set; } = Name;
    public int EnergyLvl { get; set; } = EnergyLvl;
    public void Eat(int EnergyGiven)
    {
        Console.WriteLine($"EnergyLvl przed zjedzeniem: {this.EnergyLvl}");
        EnergyLvl += EnergyGiven;
        Console.WriteLine($"EnergyLvl po zjedzeniu: {this.EnergyLvl}");
    }
}



