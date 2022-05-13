using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using ComicBookLibraryManager.Models;

namespace ComicBookGalleryModel
{
    public class Context : DbContext
    {
        public Context()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public DbSet<ComicBook> ComicBooks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Conventions.Remove<DecimalPropertyConvention>();
            //modelBuilder.Conventions.Add(new DecimalPropertyConvention(5, 2));

            modelBuilder.Entity<ComicBook>()
                .Property(cb => cb.AverageRating)
                .HasPrecision(5, 2);
        }
    }
}
