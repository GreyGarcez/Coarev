using Microsoft.AspNetCore.Mvc;

namespace CoarevApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Unities : ControllerBase
{
    // GET: api/Unities
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/<Unities>/id
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/Unities
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<Unities>/id
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/Unities/id
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
