using Microsoft.AspNetCore.Mvc;

namespace CoarevApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class Tags : ControllerBase
{
    // GET: api/Tags
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }

    // POST api/Tags
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/Tags/id
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/Tags/id
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
