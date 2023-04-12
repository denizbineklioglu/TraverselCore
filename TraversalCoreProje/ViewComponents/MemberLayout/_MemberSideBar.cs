using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProje.ViewComponents.MemberLayout
{
    public class _MemberSideBar: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
