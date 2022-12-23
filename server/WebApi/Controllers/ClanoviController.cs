using Microsoft.AspNetCore.Mvc;
using Repositories.DTOs;
using Repositories.Interfaces;

[ApiController]
[Route("[controller]")]
public class ClanoviController : ControllerBase
{
    readonly IClanovi clanovi;

    public ClanoviController(IClanovi clanovi)
    {
        this.clanovi = clanovi;
    }

    [HttpGet("ClanoviList")]
    public ActionResult<List<ClanListObject>> GetClanovi(){
        return Ok(clanovi.GetClanovi());
    }

    [HttpPost("CreateClan")]
    public ActionResult<ClanListObject> CreateClan(ClanCreation? clanCreation){
        ClanListObject? clanObj = clanovi.CreateClan(clanCreation);

        return clanObj is null ? BadRequest() : Ok(clanObj);
    }
}