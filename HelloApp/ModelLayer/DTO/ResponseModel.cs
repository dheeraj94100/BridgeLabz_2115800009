using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.DTO
{
    public class ResponseModel<T>
    {
        public string success { get; set; } = "true";
        public string message { get; set; } = "";
        public T data { get; set; }
    }
}
