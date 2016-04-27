namespace Schibsted.Infrastructure.Security.Contracts
{

    public interface IAuthenticate
    {
        bool Authenticate(string username, string password);
    }

}
