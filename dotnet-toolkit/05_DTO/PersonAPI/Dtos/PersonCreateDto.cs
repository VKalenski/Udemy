#region Usings
using System.ComponentModel.DataAnnotations;
#endregion

namespace PersonAPI.Dtos
{
    public class PersonCreateDto : PersonBaseDto
    {
        public string? House { get; set; }
    }
}