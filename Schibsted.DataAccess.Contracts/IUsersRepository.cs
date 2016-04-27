namespace Schibsted.Infrastructure.Contracts
{

    public interface IUsersRepository<T> : IReaderRepository<T> where T: class
    {
        void Initialize(string filepath);
    }

}
