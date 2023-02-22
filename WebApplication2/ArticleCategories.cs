using System.ComponentModel.DataAnnotations;

namespace WebApplication2
{
    public class ArticleCategories
    {
        public long Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(300)]
        public string Description { get; set; }
        public string? Slug { get; set; }
        public List<Article>? AssociatedPosts { get; set; }
    }
}
