using Microsoft.AspNetCore.Mvc;

namespace CoarevApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Users : ControllerBase
{
    // GET: api/Users/me
    [HttpGet("me")]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // POST api/Users
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/Users/me
    [HttpPut("me")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/Users/me
    [HttpDelete("me")]
    public void Delete(int id)
    {
    }
}
