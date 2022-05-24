using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace backedn_aiepflix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [AllowAnonymous]
        [HttpGet("get2")]
        public ActionResult<TestClass> Get2()
        {
            var valor = Request.Headers["valorHeader"].ToString();
            var obj = new TestClass() { Id = 22, Name="Lelelelelel", Check= false };
            return obj;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Petición Get");
        }

        [HttpPost]
        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles ="admin")]
        public IActionResult Post()
        {
            return Ok("Post");
        }

        [HttpPost("post2")]
        public IActionResult PostEE(TestClass value)
        {
            return Ok("Post" + value.Id.ToString());
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Put");
        }

        [HttpPatch]
        public IActionResult Patch()
        {
            return Ok("Patch");
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("Delete");
        }
    }
}
