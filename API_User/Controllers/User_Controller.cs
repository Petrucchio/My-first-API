using API_User.Filters;
using API_User.Models;
using API_User.Models.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace API_User.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class User_Controller : ControllerBase
    {
        [SwaggerResponse(statusCode: 200, description: "Sucesso ao autenticar", Type = typeof(LoginViewModelInput))]
        [SwaggerResponse(statusCode: 400, description: "Campos Obrigatórios", Type = typeof(ValidationViewModelOutput))]
        [SwaggerResponse(statusCode: 500, description: "Erro Interno", Type = typeof(GenericErrorViewModel))]
        [HttpPost]
        [Route("Login")]
        [ValidationModelStateCustomized]
        public IActionResult Login(LoginViewModelInput loginViewModelInput)
        {
            return Ok(loginViewModelInput);
        }
        [HttpPost]
        [Route("Register")]
        [ValidationModelStateCustomized]
        public IActionResult Register(RegisterViewModelInput registerViewModelInput)
        {
            return Created("", registerViewModelInput);
        }
    }
}
