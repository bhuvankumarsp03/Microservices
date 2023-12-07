namespace WebApplication40.Models
{
    public interface IJwtAuthManager
    {
        string Authenticate(string username, string password);
    }
}
