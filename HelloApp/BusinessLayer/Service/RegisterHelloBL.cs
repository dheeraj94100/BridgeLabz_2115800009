using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryLayer.Service;
using ModelLayer.DTO;
using System.Runtime.CompilerServices;
using BusinessLayer.Interface;
using RepositoryLayer.Interface;

namespace BusinessLayer.Service
{
    public class RegisterHelloBL : IRegisterHelloBL
    {
        private readonly IRegisterHelloRL _registerHelloRL;
        public RegisterHelloBL(IRegisterHelloRL registerHelloRL)
        {
            _registerHelloRL = registerHelloRL;
        }
        public string registration(string name)
        {

            return "Data from Business Layer" + _registerHelloRL.GetHello("ABC");
        }
        public bool loginuser(LoginDTO loginDTO)
        {
            string frontendusername = loginDTO.username;
            string frontendpassword = loginDTO.password;
            LoginDTO result = _registerHelloRL.GetUsernamePassword(loginDTO);
            bool res = checkUserNamePassword(frontendusername, frontendpassword, result);

            return res;
        }
        public bool checkUserNamePassword(string frontendusername, string frontendpassword, LoginDTO result)
        {
            if (result == null) return false;
            if (frontendusername.Equals(result.username) && frontendpassword.Equals(result.password))
            {
                return true;
            }
            return false;
        }
    }
}
