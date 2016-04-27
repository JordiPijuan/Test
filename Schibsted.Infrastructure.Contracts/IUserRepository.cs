namespace Schibsted.Infrastructure.Contracts
{

    public interface IUserRepository<T> where T: class
    {

        void Add(T entity);
        void Update(T entity);

    }

}
