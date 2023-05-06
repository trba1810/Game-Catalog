using System.ComponentModel.DataAnnotations;

namespace BlazorCRUD.Data
{
    public class GameModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }

    }
}
