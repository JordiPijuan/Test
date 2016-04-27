namespace Schibsted.Infrastructure.Repositories
{
    using System;
    using System.Collections.Generic;
    using Crosscutting.Entities;
    using Contracts;
    using System.Linq.Expressions;

    public class RolesRepository : IRolesRepository<Role>
    {
        private string _file;
        public string File
        {
            get { return _file; }
            set { _file = value; }
        }

        public void Initialize(string filepath)
        {
            File = filepath;
        }

        public IEnumerable<Role> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetByFilter(Expression<Func<Role, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        public Role GetById(object id)
        {
            throw new NotImplementedException();
        }

    }

}
