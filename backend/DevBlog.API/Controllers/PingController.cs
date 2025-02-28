using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevBlog.API.Controllers
{
    [Route("api/ping")]
    [ApiController]
    [Authorize] // ✅ Requires a valid JWT
    public class PingController : ControllerBase
    {
        [HttpGet]
        public IActionResult Ping()
        {
            return Ok(new { message = "pong" });
        }
    }
}
