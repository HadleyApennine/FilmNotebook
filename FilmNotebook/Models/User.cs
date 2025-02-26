namespace FilmNotebook.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // Admin / User

        // Lista filmów użytkownika (To watch, Watched)
        public ICollection<FilmList> FilmLists { get; set; }
    }
}
