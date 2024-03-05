namespace MediaRegistret.Common;

public class Book(int id, string title, string author, int pages) : Media(id, title)
{
    public string Author { get; set; } = author;
    public int Pages { get; set; } = pages;
}