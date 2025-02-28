using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DTO;
using RepositoryLayer.service;

namespace BusinessLayer.service
{
    public class UserServiceBL
    {
        UserRegistrationRL _userRegistrationRL;

        public UserServiceBL(UserRegistrationRL userRegistrationRL)
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public string RegisterUser(User user)
        {
            if (_userRegistrationRL.UserExists(user.Email))
            {
                return "User already exists";
            }
            _userRegistrationRL.AddUser(user);
            return "User added successfully";
        }
    }

}
