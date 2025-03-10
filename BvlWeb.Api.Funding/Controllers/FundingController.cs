using BvlWeb.Modules.Funding.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace BvlWeb.Api.Funding.Controllers;

[Area("Funding")]
[Route("api/[area]/[controller]")]
[ApiController]
public class FundingController : ControllerBase
{
    private readonly IFundingService _service;

    public FundingController(IFundingService service)
    {
        _service = service;
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var result = _service.GetFunding(id);
        return Ok(result);
    }
}

