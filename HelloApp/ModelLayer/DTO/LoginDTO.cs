using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//DTO is used for data migration such that i want to send data from one layer to another layer
//Entity have classes that are used to set connection between databses

namespace ModelLayer.DTO
{
    public class LoginDTO
    {
        public string username { get; set; }
        public string password { get; set; }


       
        public string ToString()
        {
            return username + ":" + password;
        }
    }
}
