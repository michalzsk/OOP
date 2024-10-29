
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



