using ModelLayer.DTO;
using RepositoryLayer.Interface;
namespace RepositoryLayer.Service
{
    public class RegisterHelloRL : IRegisterHelloRL
    {
        private string _username = "root";
        private string _password = "root";

        public RegisterHelloRL()
        {

        }

        public string GetHello(string name)
        {
            return "This is repository layer data = " + name;
        }
        public LoginDTO GetUsernamePassword(LoginDTO loginDTO)
        {
            loginDTO.username = _username;
            loginDTO.password = _password;
            return loginDTO;
        }
    }
}
