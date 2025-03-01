using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Service;
using ModelLayer.DTO;
using BusinessLayer.Interface;

namespace HelloApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloAppController : ControllerBase
    {
        ResponseModel<string> Response;
        private readonly IRegisterHelloBL _registerHelloBL;
        public HelloAppController(IRegisterHelloBL registerHelloBL)
        {
            _registerHelloBL = registerHelloBL;
        }
        [HttpGet]
        public string Get()
        {
            return _registerHelloBL.registration("value from controller");
        }
        [HttpPost]
        public ResponseModel<string> Postdata(LoginDTO loginDTO)
        {
            bool result = _registerHelloBL.loginuser(loginDTO);
            Response = new ResponseModel<string>();
            if (result)
            {
                Response.success = "true";
                Response.message = "Login Successful";
                Response.data = loginDTO.username;
                return Response;
            }
            Response.success = "false";
            Response.message = "Login Unsuccessful";
            Response.data = "";
            return Response;
        }
        // To String method poco class mein override karna padta hai
    }

}
