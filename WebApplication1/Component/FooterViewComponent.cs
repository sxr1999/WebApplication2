using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Component
{
    public class FooterViewComponent : ViewComponent
    {
       

        public IViewComponentResult Invoke()
        {
            return View("footer");
        }
    }
}
