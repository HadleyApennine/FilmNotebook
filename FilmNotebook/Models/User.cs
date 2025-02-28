namespace FilmNotebook.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Nickname { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; } // Admin / User

        // Lista filmów użytkownika (To watch, Watched)
        public List<FilmList> FilmLists { get; set; } = new();
    }
}