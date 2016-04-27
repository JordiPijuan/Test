namespace Schibsted.Crosscutting.Security.Contracts
{

    public interface IAuthenticate
    {
        bool Authenticate(string username, string password);
    }

}
