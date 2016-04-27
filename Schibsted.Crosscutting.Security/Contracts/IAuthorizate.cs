namespace Schibsted.Crosscutting.Security.Contracts
{

    public interface IAuthorizate
    {
        ISchibstedIdentity Authorize(string username);
    }

}
