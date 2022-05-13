using System.Collections.Generic;
using ComicBookCRUD.Models;

namespace ComicBookLibraryManager.Models
{
    public class PublishingHouse
    {
        public PublishingHouse()
        {
            ComicBookPublishingHouses = new List<ComicBookPublishingHouse>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }

        public ICollection<ComicBookPublishingHouse> ComicBookPublishingHouses { get; set; }
    }
}