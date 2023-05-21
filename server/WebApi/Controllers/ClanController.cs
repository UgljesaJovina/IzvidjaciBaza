using Microsoft.AspNetCore.Mvc;
using Services.DTOs;
using Services.Interfaces;

[ApiController]
[Route("[controller]")]
public class ClanController : ControllerBase
{
    readonly IClanService clanService;

    public ClanController(IClanService clanovi)
    {
        this.clanService = clanovi;
    }

    [HttpGet("ClanList")]
    public ActionResult<ICollection<ClanShortObject>> GetActive(){
        return Ok(clanService.GetActive());
    }

    [HttpGet("GetClan/{id}")]
    public ActionResult<DisplayClan> GetClan(Guid id) {
        DisplayClan? dClan = clanService.GetById(id);
        if (dClan is null) return NotFound();
        return Ok(dClan);
    }

    [HttpPost("CreateClan")]
    public ActionResult<ClanShortObject> CreateClan(ClanCreation? clanCreation){
        ClanShortObject? c = clanService.Create(clanCreation);
        if (c is null) return BadRequest();
        return Ok(c);
    }

    [HttpDelete("DeleteClan/{id}")]
    public ActionResult DeleteClan(Guid id){
        return clanService.Delete(id) ? Ok() : NotFound();
    }

    [HttpPut("UpdateClan/{id}")]
    public ActionResult<DisplayClan> UpdateClan(Guid id, DisplayClan? displayClan) {
        DisplayClan? c = clanService.Update(id, displayClan);

        return c is null ? NotFound() : Ok(c);
    }

    [HttpGet("GetKazne/{id}")]
    public ActionResult<ICollection<KaznaShortObject>> GetKazne(Guid id) {
        ICollection<KaznaShortObject>? kazne = clanService.GetKazne(id)?.ToList();
        return kazne is null ? NotFound() : Ok(kazne);
    }

    [HttpGet("GetKazna/{kaznaId}")]
    public ActionResult<DisplayKazna> GetKazna(Guid kaznaId) {
        DisplayKazna? kazna = clanService.GetKaznaById(kaznaId);
        if (kazna is null) return NotFound();
        return Ok(kazna);
    }

    [HttpPost("CreateKazna/{id}")]
    public ActionResult<KaznaShortObject> CreateKazna([FromRoute]Guid id, [FromBody]KaznaCreation? kazna){
        KaznaShortObject? retKazna = clanService.CreateKazna(id, kazna);
        if (retKazna is null) return BadRequest();
        return Ok(retKazna);
    }

    [HttpDelete("DeleteKazna/{clanId}/{kaznaId}")]
    public ActionResult DeleteKazna(Guid clanId, Guid kaznaId) {
        bool b = clanService.DeleteKazna(clanId, kaznaId);
        return b ? Ok() : NotFound();
    }
}