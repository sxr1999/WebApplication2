using System.ComponentModel.DataAnnotations;

namespace WebApplication2
{
    public class Article
    {
        public long ArticleId { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        public ArticleCategories PostCategory { get; set; }
        public string? Test { get; set; }
    }
}
