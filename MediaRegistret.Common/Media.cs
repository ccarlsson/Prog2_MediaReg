namespace MediaRegistret.Common;



public class Media(int id, string title)
{
    public int Id { get; set; } = id;
    public string Title { get; set; } = title;
}