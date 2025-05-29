#region Usings
using System.ComponentModel.DataAnnotations;
#endregion

namespace PersonAPI.Dtos
{
    public class PersonReadDto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? FullName { get; set; }

        [Required]
        public string? Telephone { get; set; }

        // [Required]
        // public string? DoB { get; set; }

        public int Age { get; set; }

        public string? House { get; set; }

        public int Points { get; set; }
    }
}