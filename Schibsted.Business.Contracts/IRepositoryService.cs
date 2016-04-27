namespace Schibsted.Business.Contracts
{
    using System.Collections.Generic;
    using Crosscutting.Entities;

    public interface IRepositoryService
    {
        string FilePath { get; set; }
        void Initialize(string filepath);
        List<User> GetAllUsers();
        User GetByName(string name);
        bool Authenticate(string username, string password);

    }

}
