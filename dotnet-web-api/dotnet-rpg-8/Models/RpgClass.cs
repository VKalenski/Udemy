#region Usings
using System.Text.Json.Serialization;
#endregion

namespace dotnet_rpg.Models
{
    #region Properties RpgClass
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Mage = 2,
        Cleric = 3
    }
    #endregion
}