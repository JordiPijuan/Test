using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schibsted.Business.Contracts;
using Schibsted.Infrastructure.Entities;
using Schibsted.Infrastructure.Contracts;
using Schibsted.Infrastructure.Repositories;

namespace Schibsted.Business.Core
{
    public class RepositoryService : IRepositoryService
    {
        private readonly IUsersRepository<User> _userRepository;

        public string FilePath { get; set; }

        public RepositoryService(IUsersRepository<User> usersRepository)
        {
            _userRepository = usersRepository;
        }

        public void Initialize(string filepath)
        {
            FilePath = filepath;

            _userRepository.Initialize(FilePath);
        }

        public List<User> GetAllUsers()
        {
            return _userRepository.GetAll().ToList();
        }

        public User GetByName(string name)
        {
            return _userRepository.GetById(name);
        }

    }
}
