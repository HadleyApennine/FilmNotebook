namespace FilmNotebook.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Relacja wiele do wielu z filmami
        public ICollection<FilmCategory> FilmCategories { get; set; }
    }
}
