
//nuova biblioteca
Bibilioteca bibilioteca = new Bibilioteca();
//nuovo user
User userRegistrato = new User("Marcon", "Alberto", "lamiamail@mail.com","password", 1234561234);
User userNonRegistrato = new User("Rossi", "Marco", "lamiamail@mail.com", "password", 1234561234);
//aggiunta user
bibilioteca.AddNewUser(userRegistrato);
//nuovo libro
Book nuovoLibro = new Book("ad1231312fsd", "Harry Potter e la pietra filosofale");
//Test Getter e Setter Nuovo Libro
nuovoLibro.Pagine = 750;
Console.WriteLine(nuovoLibro.Title);
Console.WriteLine(nuovoLibro.Pagine);
//nuovo film
Movie nuovoFilm = new Movie("ad65452342fsd", "Superman il grande super eroe");
//test getter e setter nuovo film
nuovoFilm.Durata = 98;
Console.WriteLine(nuovoFilm.Title);
Console.WriteLine(nuovoFilm.Durata);
nuovoFilm.AuthorLastName = "Rossi";
nuovoFilm.AuthorFirstName = "Mario";
//test full name autore
Console.WriteLine(nuovoFilm.FullAuthorName);
//aggiunti prodotti alla biblioteca
bibilioteca.AddMovie(nuovoFilm);
bibilioteca.AddBook(nuovoLibro);
//risultati di ricerca
List<Product> risultati = bibilioteca.SearchProduct("Potter");
Console.WriteLine(risultati[0].Title);
//test prestito

bibilioteca.NuovoPrestito(nuovoFilm, userRegistrato, DateOnly.FromDateTime(DateTime.Now), DateOnly.FromDateTime(DateTime.Now));
//test ricerca prestito, funzionante a meno di controlli
Console.WriteLine("Nome del prestito");
string nomeRicerca = Console.ReadLine();
Console.WriteLine("Cognome del prestito");

string cognomeRicerca = Console.ReadLine();

var ricercaPrestiti = bibilioteca.CercaPrestito(nomeRicerca, cognomeRicerca);

if (ricercaPrestiti.Count > 0) { 
    foreach(Prestito el in ricercaPrestiti)
    {
        Console.WriteLine(el.User.FirstName + " " + el.User.LastName);
        Console.WriteLine("Durata");
        Console.WriteLine(el.dataInizio);
        Console.WriteLine(el.dataFine);
    }
}
else Console.WriteLine("Nessun prestito registrato con quel nome utente");
