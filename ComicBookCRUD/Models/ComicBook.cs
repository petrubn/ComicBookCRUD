using System;
using System.Collections.Generic;
using ComicBookCRUD.Models;

namespace ComicBookLibraryManager.Models
{
    /// <summary>
    /// Represents a comic book.
    /// </summary>
    public class ComicBook
    {
        public ComicBook()
        {
            Artists = new List<ComicBookArtist>();
            PublishingHouses = new List<ComicBookPublishingHouse>();
        }

        public int Id { get; set; }
        public int SeriesId { get; set; }
        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        public decimal? AverageRating { get; set; }
        // public string PublishingHouse { get; set; }

        public Series Series { get; set; }
        public ICollection<ComicBookArtist> Artists { get; set; }
        public ICollection<ComicBookPublishingHouse> PublishingHouses { get; set; }

        /// <summary>
        /// The display text for a comic book.
        /// </summary>
        public string DisplayText
        {
            get
            {
                return $"{Series?.Title} #{IssueNumber}";
            }
        }

        /// <summary>
        /// Adds an artist to the comic book.
        /// </summary>
        /// <param name="artist">The artist to add.</param>
        /// <param name="role">The role that the artist had on this comic book.</param>
        public void AddArtist(Artist artist, Role role)
        {
            Artists.Add(new ComicBookArtist()
            {
                Artist = artist,
                Role = role
            });
        }
        
        public void AddPublishingHouse(PublishingHouse publishingHouse)
        {
            PublishingHouses.Add(new ComicBookPublishingHouse
            {
                PublishingHouse = publishingHouse
            });
        }
    }
}
