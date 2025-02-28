using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;

namespace RepositoryLayer.service
{
    public class UserRegistrationRL
    {
        private List<User> _users = new List<User>();

        public bool UserExists(string email)
        {
            return _users.Any(u => u.Email == email);
        }

        public void AddUser(User user)
        {
            _users.Add(user);
        }
    }
}
