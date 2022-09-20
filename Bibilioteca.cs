// See https://aka.ms/new-console-template for more information
public class Bibilioteca {
    //lista utenti registrati
     protected List<User> RegisterdUsers = new List<User>();
    //lista film 
    protected List<Movie> Movies = new List<Movie>();
    //lista Libri
    protected List<Book> Books = new List<Book>();
    //list di prestiti
    //protected List<Presitit>
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
    public List<Product> SearchProduct(string titolo) {
        List<Product> risultati = new List<Product>();
        foreach (Movie movie in Movies)
        {
            if (movie.Title.ToLower().Contains(titolo.ToLower()))
            {
                risultati.Add(movie);
            }
        }
        foreach (Book book in Books) { 
            if (book.Title.ToLower().Contains(titolo.ToLower()))
            {
               risultati.Add(book);
            }
        }
        return risultati;
    }
    //public List<Product> SearchProduct(string codice)
    //{
    //    List<Product> risultati = new List<Product>();
    //    foreach (Movie movie in Movies)
    //    {
    //        if (movie.SerialCode.ToLower().Contains(codice.ToLower()))
    //        {
    //            risultati.Add(movie);
    //        }
    //    }
    //    foreach (Book book in Books)
    //    {
    //        if (book.SerialCode.ToLower().Contains(codice.ToLower()))
    //        {
    //            risultati.Add(book);
    //        }
    //    }
    //    return risultati;
    //}
}