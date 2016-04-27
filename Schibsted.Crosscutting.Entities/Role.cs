using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schibsted.Infrastructure.Entities
{

    public class Role
    {

        public string Name { get; set; }

        public virtual IList<User> Users { get; set; }

        public string GetRole()
        {
            return Name;
        }

        public List<string> GetAllUsers()
        {
            return (List<string>)Users;
        }

    }

}
