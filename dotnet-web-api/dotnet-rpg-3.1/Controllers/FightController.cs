#region Usings
using dotnet_rpg.Dtos.Fight;
using dotnet_rpg.Services.FightService;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
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

        #region POST
        [HttpPost("Weapon")]
        public async Task<IActionResult> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }

        [HttpPost("Skill")]
        public async Task<IActionResult> SkillAttack(SkillAttackDto request)
        {
            return Ok(await _fightService.SkillAttack(request));
        }

        [HttpPost]
        public async Task<IActionResult> Fight(FightRequestDto request)
        {
            return Ok(await _fightService.Fight(request));
        }

        public async Task<IActionResult> GetHighscore()
        {
            return Ok(await _fightService.GetHighscore());
        }
        #endregion
    }
}