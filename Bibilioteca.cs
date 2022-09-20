// See https://aka.ms/new-console-template for more information
public class Bibilioteca {
    //lista utenti registrati
    List<User> RegisterdUsers = new List<User>();
    //aggiungi e rimuove utente dalla lista
    public void AddNewUser(User utente) {
        RegisterdUsers.Add(utente);
    }
    public void RemoveUser(User utente)
    {
        RegisterdUsers.Remove(utente);
    }
}