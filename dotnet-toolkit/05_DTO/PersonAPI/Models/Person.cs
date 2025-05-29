#region Usings
using System.ComponentModel.DataAnnotations;
#endregion

namespace PersonAPI.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? FullName { get; set; }

        [Required]
        public string? Telephone { get; set; }

        [Required]
        public string? DoB { get; set; }

        public int YearsAlive { get {
            var today = DateTime.Today;

            var splidDoB = DoB!.Split("-");

            return today.Year - int.Parse(splidDoB[0]);
        }  }

        public string? House { get; set; }

        public int Points { get; set; }

    }
}