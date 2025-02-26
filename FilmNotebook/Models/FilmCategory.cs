using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FilmNotebook.Models
{
    public class FilmCategory
    {
        [Key, Column(Order = 0)]
        public int FilmId { get; set; }
        public Film Film { get; set; }

        [Key, Column(Order = 1)]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
