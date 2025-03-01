using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interface
{
    public interface IRegisterHelloBL
    {
        public string registration(string name);
        public bool loginuser(ModelLayer.DTO.LoginDTO loginDTO);
    }
}
