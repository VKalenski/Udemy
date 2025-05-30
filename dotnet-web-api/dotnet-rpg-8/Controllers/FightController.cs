#region Usings
using Microsoft.AspNetCore.Mvc;
using dotnet_rpg.Dtos.Fight;
#endregion

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FightController : ControllerBase
    {
        #region Fields
        private readonly IFightService _fightService;
        #endregion

        #region Ctor
        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }
        #endregion

        #region GET
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<HighscoreDto>>>> GetHighscore()
        {
            return Ok(await _fightService.GetHighscore());
        }
        #endregion

        #region POST
        [HttpPost("Weapon")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }

        [HttpPost("Skill")]
        public async Task<ActionResult<ServiceResponse<AttackResultDto>>> SkillAttack(SkillAttackDto request)
        {
            return Ok(await _fightService.SkillAttack(request));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<FightResultDto>>> Fight(FightRequestDto request)
        {
            return Ok(await _fightService.Fight(request));
        }
        #endregion
    }
}