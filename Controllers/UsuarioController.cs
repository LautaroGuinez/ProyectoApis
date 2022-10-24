using Apis.Models;
using Apis.Repository;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Apis.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        // GET: api/<UsuarioController>
        [HttpGet(Name ="Consultar Usuario")]
        public Usuario GetUsuario(string nombreUsuario)
        {

            return ADO_Usuario.TraerUsuario(nombreUsuario);

        }
    }
}
