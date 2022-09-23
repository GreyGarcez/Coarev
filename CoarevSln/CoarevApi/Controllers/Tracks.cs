using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoarevApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Tracks : ControllerBase
{
    // GET: api/Tracks
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // GET api/Tracks/id
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return "value";
    }

    // POST api/Tracks
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/Tracks/id
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/Tracks/id
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
