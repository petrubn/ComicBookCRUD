using ComicBookLibraryManager.Models;

namespace ComicBookCRUD.Models
{
    public class ComicBookPublishingHouse
    {
        public int Id { get; set; }
        public int PublishingHouseId { get; set; }
        public int ComicBookId { get; set; }

        public PublishingHouse PublishingHouse { get; set; }
        public ComicBook ComicBook { get; set; }
    }
}