#region Usings
using System.Text.Json.Serialization;
#endregion

namespace dotnet_rpg.Models
{
    #region Properties Models
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight,
        Mage,
        Cleric
    }
    #endregion
}