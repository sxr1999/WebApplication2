using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Component
{
    
    public class UserViewComponent : ViewComponent
    {
        private readonly IHttpContextAccessor _httpContext;
        public UserViewComponent(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }

        public IViewComponentResult Invoke()
        {
            var username = _httpContext.HttpContext.Session.GetString("UserName");
            return View("index",username);
        }

    }
}
