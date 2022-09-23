using Microsoft.AspNetCore.Mvc;

namespace CoarevApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Actions : ControllerBase
{
    // GET: api/Actions
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/Actions/id
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/Actions
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/Actions/id
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/Actions/id
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
