using Microsoft.AspNetCore.Mvc;

namespace BlazorGetTest.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdviceController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAdvice()
        {
            var advice = new { Advice = "Stay positive, keep learning!" };
            return Ok(advice);
        }
    }
}
