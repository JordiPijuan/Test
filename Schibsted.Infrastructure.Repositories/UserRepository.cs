
namespace Schibsted.Infrastructure.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using Crosscutting.Commons;
    using Crosscutting.Commons.Managers;
    using Crosscutting.Entities;
    using Contracts;

    public class UserRepository : IUserRepository<User>
    {

        public string File { get; set; }

        private List<User> UserList { get; set; }

        public void Initialize(string filepath)
        {
            File = filepath;
            var model = FileManager.ReadFileToString(File);
            UserList = JsonSerializer.FromJson<List<User>>(model);
        }

        public void Add(User newEntity)
        {
            UserList.Add(newEntity);

            var result = JsonSerializer.ToJson(UserList);
            FileManager.CreateFile(File, result);
        }

        public void Update(User entityToUpdate)
        {
            var user = UserList.SingleOrDefault(u => u.Name == entityToUpdate.Name);

            UserList.Remove(user);
            UserList.Add(entityToUpdate);

            var result = JsonSerializer.ToJson(UserList);
            FileManager.CreateFile(File, result);
        }

    }

}
