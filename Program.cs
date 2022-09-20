
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
