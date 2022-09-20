// See https://aka.ms/new-console-template for more information
public class Bibilioteca {
    //lista utenti registrati
     protected List<User> RegisterdUsers = new List<User>();
    //lista film 
    protected List<Movie> Movies = new List<Movie>();
    //lista Libri
    protected List<Book> Books = new List<Book>();
    //aggiungi e rimuove utente dalla lista
    public void AddNewUser(User utente) {
        utente.Registrato = true;
        RegisterdUsers.Add(utente);
        
    }
    public void RemoveUser(User utente)
    {
        RegisterdUsers.Remove(utente);
    }
    //aggiungi o rimuovi film dalla biblioteca
    public void AddMovie(Movie movie) {
        Movies.Add(movie);
    }
    public void RemoveMovie(Movie movie) {
        Movies.Remove(movie);
    }
    //aggiungi o rimuovi Libro dalla biglioteca
    public void AddBook(Book book) {
        Books.Add(book);
    }
    public void RemoveBook(Book book)
    {
        Books.Remove(book);
    }
    //ricerca per utente
    public void SearchProduct(string ricerca) {
        List<Product> risultati = new List<Product>();
        foreach (Movie movie in Movies)
        {
            if (movie.Title.Contains(ricerca))
            {
                risultati.Add(movie);
            }
        }
        foreach (Book book in Books) { 
            if (book.Title.Contains(ricerca))
            {
               risultati.Add(book);
            }
        }
        Console.WriteLine(risultati.ToArray());
    }
}