using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace pw2_clase5.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet("public")]
        public IActionResult GetPublic()
        {
            return Ok(new { message = "acceso publico" });
        }

        [HttpGet("protected")]
        [Authorize]
        public IActionResult GetProtected()
        {
            return Ok(new { message = "acceso protegido" });
        }

        [HttpGet("admin")]
        [Authorize(Policy = "AdminOnly")]
        public IActionResult GetAdmin()
        {
            return Ok(new { message = "acceso admin" });
        }

        [HttpGet("user")]
        [Authorize(Policy = "UserOnly")]
        public IActionResult GetUser()
        {
            return Ok(new { message = "acceso user" });
        }
    }
}
