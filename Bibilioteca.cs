// See https://aka.ms/new-console-template for more information
public class Bibilioteca {
    //lista utenti registrati
    List<User> RegisterdUsers = new List<User>();
    //lista film 
    List<Movie> Movies = new List<Movie>();
    //lista Libri
    List<Book> Books = new List<Book>();
    //aggiungi e rimuove utente dalla lista
    public void AddNewUser(User utente) {
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
}