using Schibsted.Crosscutting.Commons;
using Schibsted.Crosscutting.Commons.Managers;
using Schibsted.Crosscutting.Entities;

namespace Schibsted.Infrastructure.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using Schibsted.Crosscutting.Commons;
    using Schibsted.Crosscutting.Commons.Managers;
    using Schibsted.Crosscutting.Entities;
    using Schibsted.Infrastructure.Contracts;

    public class UsersRepository : IUsersRepository<User>
    {
        private List<User> UserList { get; set; }

        public void Initialize(string filepath)
        {
            var model = FileManager.ReadFileToString(filepath);
            UserList = JsonSerializer.FromJson<List<User>>(model);
        }

        public IEnumerable<User> GetAll()
        {
            return UserList;
        }

        public IEnumerable<User> GetByFilter(Expression<Func<User, bool>> filter = null)
        {
            return UserList.AsQueryable().Where(filter);
        }

        public User GetById(object id)
        {
            return UserList.SingleOrDefault(u => u.Name == (string)id);
        }


    }

}
