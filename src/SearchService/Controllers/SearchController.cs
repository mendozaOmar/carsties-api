using Microsoft.AspNetCore.Mvc;

namespace SearchService;

[ApiController]
[Route("api/search")]
public class SearchController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<Item>> SearchItems(string searchTerm)
    {
        
    }
}
