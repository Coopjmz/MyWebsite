using System;

namespace MyWebsite.Models
{
    public class CommentEntry
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }

        public DateTime Date { get; set; }
    }
}