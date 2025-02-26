namespace FilmNotebook.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int ReleaseYear { get; set; }
        public string Description { get; set; }

        // Relacja wiele do wielu z kategoriami
        public ICollection<FilmCategory> FilmCategories { get; set; }
    }
}
