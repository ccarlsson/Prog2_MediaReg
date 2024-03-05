using MediaRegistret.Common;

namespace MediaRegistret;
public static class MediaExtension
{
    public static string ToDisplayString(this Media media) => media switch
    {
        Book b => $"{b.Title} av {b.Author} ({b.Pages} sidor)",
        Movie m => $"{m.Title} av {m.Director} ({m.Length} minuter)",
        _ => throw new ArgumentException("Unknown media type")
    }; 
}
