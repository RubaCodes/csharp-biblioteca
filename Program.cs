
//nuova biblioteca
Bibilioteca bibilioteca = new Bibilioteca();
//nuovo user
User user = new User("Marcon", "Alberto", "lamiamail@mail.com","password", 1234561234);
//aggiunta user
bibilioteca.AddNewUser(user);
//nuovo libro
Book nuovoLibro = new Book("ad1231312fsd", "Harry Potter e la pietra filosofale");
nuovoLibro.Pagine = 750;
Console.WriteLine(nuovoLibro.Title);
Console.WriteLine(nuovoLibro.Pagine);
Movie nuovoFilm = new Movie("ad65452342fsd", "Superman il grande super eroe");
nuovoFilm.Durata = 98;
Console.WriteLine(nuovoFilm.Title);
Console.WriteLine(nuovoFilm.Durata);
nuovoFilm.AuthorLastName = "Rossi";
nuovoFilm.AuthorFirstName = "Mario";
Console.WriteLine(nuovoFilm.FullAuthorName);
bibilioteca.AddMovie(nuovoFilm);
bibilioteca.AddBook(nuovoLibro);
var risulati = bibilioteca.SearchProduct("Super");
Console.WriteLine(risulati[0].Title);



