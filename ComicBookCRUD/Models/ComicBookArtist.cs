using ComicBookLibraryManager.Models;

namespace ComicBookCRUD.Models
{
    /// <summary>
    /// Represents a comic book artist.
    /// </summary>
    public class ComicBookArtist
    {
        public int Id { get; set; }
        public int ComicBookId { get; set; }
        public int ArtistId { get; set; }
        public int RoleId { get; set; }

        public ComicBook ComicBook { get; set; } 
        public Artist Artist { get; set; }
        public Role Role { get; set; }
    }
}
