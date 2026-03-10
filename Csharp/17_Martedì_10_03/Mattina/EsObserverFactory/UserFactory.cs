public static class UserFactory
{
    public static Utente Crea(string nome)
    {
        return new Utente(nome);
    }
}