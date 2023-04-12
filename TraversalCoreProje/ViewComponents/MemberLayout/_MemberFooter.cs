using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberLayout
{
    public class _MemberFooter: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
