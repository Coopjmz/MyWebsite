using System.Data.Entity;

namespace MyWebsite.Models
{
    public class CommentContext : DbContext
    {
        public CommentContext()
            : base("Comment")
        {
        }

        public DbSet<CommentEntry> Entries { get; set; }
    }
}