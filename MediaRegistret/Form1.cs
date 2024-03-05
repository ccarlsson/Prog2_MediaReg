using MediaRegistret.Dal;
using MediaRegistret.Common;

namespace MediaRegistret;

public partial class Form1 : Form
{
    private readonly MediaRepository _mediaRepository;

    public Form1()
    {
        InitializeComponent();
        _mediaRepository = new MediaRepository("Server=192.168.1.127;Database=MediaDb;User Id=sa;Password=gurkHammare#3;TrustServerCertificate=true;");
         rbAll.Checked = true;
    }


    private void btnAddBook_Click(object sender, EventArgs e)
    {
        var book = new Book(0, tbxBookTitle.Text, tbxBookAuthor.Text, (int)numBookPages.Value);
        _mediaRepository.AddBook(book);
        Form1_Load(sender, e);
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        List<Media> media = new();
        if (rbBooks.Checked)
        {
            IEnumerable<Book> books = _mediaRepository.GetAllBooks();
            media.AddRange(books);
        }
        else if (rbMovies.Checked)
        {
            IEnumerable<Movie> movies = _mediaRepository.GetAllMovies();
            media.AddRange(movies);
        }
        else
        {
            IEnumerable<Book> books = _mediaRepository.GetAllBooks();
            IEnumerable<Movie> movies = _mediaRepository.GetAllMovies();
            media.AddRange(books);
            media.AddRange(movies);
        }

        UpdateListBox(media);
    }


    private void UpdateListBox(IEnumerable<Media> media)
    {
        listBox1.Items.Clear();
        foreach (var m in media)
        {
            listBox1.Items.Add(m.ToDisplayString());
        }
    }

    private void btnAddMovie_Click(object sender, EventArgs e)
    {
        var movie = new Movie(0, tbxMovieTitle.Text, tbxMovieDirector.Text, (int)numMovieLength.Value);
        _mediaRepository.AddMovie(movie);
        Form1_Load(sender, e);
    }

    private void rb_CheckedChanged(object sender, EventArgs e)
    {
        Form1_Load(sender, e);
    }

    private void listbox_Click(object sender, EventArgs e)
    {
    }
}
