using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace WebApplication2.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        private readonly ApplicationDbContext _context;

        public PrivacyModel(ILogger<PrivacyModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        
        public ArticleCategories NewArticleCategory { get; set; }
        [BindProperty]
        public Article BlogArticle { get; set; }

        [BindProperty]
        public List<SelectListItem> PostCategories
        {

            get
            {

                List<SelectListItem> NewList = new List<SelectListItem>();

                NewList = _context.ArticleCategories.Select(a =>
                                      new SelectListItem
                                      {
                                          Value = a.Id.ToString(),
                                          Text = a.Title.ToString(),
                                      }).ToList();

                return NewList;

            }

        }

        public void OnGet()
        {
            ViewData["partial"] = HttpContext.Session.GetString("UserName");
        }

        public IActionResult OnPost()
        {
            var PostCategory = _context.ArticleCategories.Where(c => c.Id == BlogArticle.PostCategory.Id).FirstOrDefault();
            if (PostCategory != null)
            {

                BlogArticle.PostCategory = PostCategory;
            }

            if (ModelState.Remove("BlogArticle.PostCategory.Title")&& ModelState.Remove("BlogArticle.PostCategory.Description"))
            {
                if(!ModelState.IsValid)
                return Page();
            }

            return Page();
        }
    }
}