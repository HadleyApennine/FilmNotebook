namespace FilmNotebook.Models
{
    public class FilmList
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FilmId { get; set; }
        public string Status { get; set; } // "To Watch" / "Watched"

        public User User { get; set; }
        public Film Film { get; set; }
    }
}
