using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoarevApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TrackTypes : ControllerBase
{
    // GET: api/TrackTypes
    [HttpGet]
    public string Get() 
    {
        return string.Empty;
    }
}
