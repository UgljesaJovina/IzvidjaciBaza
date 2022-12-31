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

    [HttpGet("GetClan/{id}")]
    public ActionResult<DisplayClan> GetClan(Guid id) {
        DisplayClan? dClan = clanovi.GetClan(id);
        if (dClan is null) return NotFound();
        return Ok(dClan);
    }

    [HttpPost("CreateClan")]
    public ActionResult<ClanListObject> CreateClan(ClanCreation? clanCreation){
        ClanListObject? c = clanovi.CreateClan(clanCreation);
        if (c is null) return BadRequest();
        return Ok(c);
    }

    [HttpDelete("DeleteClan/{id}")]
    public ActionResult DeleteClan(Guid id){
        if (clanovi.DeleteClan(id)) return Ok();
        return NotFound();
    }

    [HttpGet("GetKazna/{kaznaId}")]
    public ActionResult<DisplayKazna> GetKazne(Guid kaznaId){
        DisplayKazna? kazna = clanovi.GetKazna(kaznaId);
        if (kazna is null) return NotFound();
        return Ok(kazna);
    }

    [HttpPost("CreateKazna/{id}")]
    public ActionResult<KaznaListObject> CreateKazna([FromRoute]Guid id, [FromBody]KaznaCreation? kazna){
        KaznaListObject? retKazna = clanovi.CreateKazna(id, kazna);
        if (retKazna is null) return BadRequest();
        return Ok(retKazna);
    }

    [HttpDelete("DeleteKazna/{id}")]
    public ActionResult<KaznaListObject> DeleteKazna(Guid id){
        KaznaListObject? k = clanovi.DeleteKazna(id);
        if (k is null) return NotFound();
        return Ok(k);
    }
}