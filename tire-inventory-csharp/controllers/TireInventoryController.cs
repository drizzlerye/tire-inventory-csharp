using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("[controller]")]
public class TireInventoryController : ControllerBase
{
    [HttpGet]
    public ActionResult<List<TireBrand>> getTireBrands()
    {
        return new List<TireBrand>();
    }
}