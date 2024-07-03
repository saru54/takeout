using commen;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Newtonsoft.Json;

namespace skytakeout.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public void TestError()
        {
            throw new NotImplementedException("测试错误");
        }
        [HttpPost("post")]
        public IActionResult Get()
        {
            var result = Result<string>.Error("傻逼");
            return Ok(result);
        }
    }
}
