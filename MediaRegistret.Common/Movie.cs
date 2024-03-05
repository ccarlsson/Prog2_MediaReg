namespace MediaRegistret.Common;

public class Movie(int id, string title, string director, int length) : Media(id, title)
{
  

    public string Director { get; set; } = director;
    public int Length { get; set; } = length;
}