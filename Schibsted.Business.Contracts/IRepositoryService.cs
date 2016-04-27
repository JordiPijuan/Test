﻿namespace Schibsted.Business.Contracts
{
    using System.Collections.Generic;
    using Schibsted.Infrastructure.Entities;
    using Schibsted.Infrastructure.Repositories;

    public interface IRepositoryService
    {
        string FilePath { get; set; }
        void Initialize(string filepath);
        List<User> GetAllUsers();
        User GetByName(string name);
    }

}
