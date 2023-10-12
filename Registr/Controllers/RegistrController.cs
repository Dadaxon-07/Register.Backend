using Microsoft.AspNetCore.Mvc;
using Register.Backend.Repository;

namespace Register.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RegistrController : Controller
    {
        private readonly Service _service;

        public RegistrController(Service service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult>LogIn(string email, string password)
        {
          var res = await _service.LogIn(email, password);
            if(res == false)
            {
                return BadRequest();

            }
            return Ok();
        }


    }
}
