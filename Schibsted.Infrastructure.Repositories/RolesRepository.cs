namespace Schibsted.Infrastructure.Repositories
{
    using System;
    using System.Collections.Generic;
    using Entities;

    public class RolesRepository : IRolesRepository<Role>
    {
        private string _File;
        public string File
        {
            get { return _File; }
            set { _File = value; }
        }

        public void Initialize(string filepath)
        {
            File = filepath;
        }

        public IEnumerable<Role> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Role> GetByFilter(Func<Role, bool> filter)
        {
            throw new NotImplementedException();
        }

        public Role GetById(object id)
        {
            throw new NotImplementedException();
        }
    }
}
