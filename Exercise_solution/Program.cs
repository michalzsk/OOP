
Book g1 = new Book("Ewok", "Michal Kluczynski", 69);
Book g2 = new Book("asd", "asd", 123);
g1.view();
g2.view();
Book g3 = new Book("","",0);
g3.add();
g3.view();


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



