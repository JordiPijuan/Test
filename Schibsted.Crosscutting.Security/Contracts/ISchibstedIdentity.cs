namespace Schibsted.Crosscutting.Security.Contracts
{
    using System.Collections.Generic;

    public interface ISchibstedIdentity
    {
        string UserName { get; set; }

        string Password { get; set; }

        IList<string> Roles { get; set; }
    }

}
