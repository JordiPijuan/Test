namespace Schibsted.Infrastructure.Security.Contracts
{

    public interface IAuthorizate
    {
        ISchibstedIdentity Authorize(string username);
    }

}
