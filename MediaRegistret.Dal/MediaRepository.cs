using Dapper;
using MediaRegistret.Common;
using Microsoft.Data.SqlClient;

namespace MediaRegistret.Dal;

public class MediaRepository(string connectionString)
{
    #region Create
    public Book AddBook(Book book)
    {
        throw new NotImplementedException();
    }

    public Movie AddMovie(Movie movie)
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Read
    public Book? GetBook(int id)
    {
        throw new NotImplementedException();
    }

    public Movie? GetMovie(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Book> GetAllBooks()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Movie> GetAllMovies()
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Update

    public Book UpdateBook(Book book)
    {
        throw new NotImplementedException();
    }

    public Movie UpdateMovie(Movie movie)
    {
        throw new NotImplementedException();
    }

    #endregion

    #region Delete 
    public bool DeleteBook(int id)
    {
        throw new NotImplementedException();
    }

    public bool DeleteMovie(int id)
    {
        throw new NotImplementedException();
    }

    #endregion
}
