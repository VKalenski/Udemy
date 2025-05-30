#region Usings
using System.Collections.Generic;
#endregion

namespace dotnet_rpg.Models
{
    #region Properties Skill
    public class Skill
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public List<CharacterSkill> CharacterSkills { get; set; }
    }
    #endregion
}