namespace Schibsted.Infrastructure.Contracts
{
    public interface IRolesRepository<T> : IReaderRepository<T> where T: class
    {
        string File { get; set; }

        void Initialize(string filepath);

    }
}
