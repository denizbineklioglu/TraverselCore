using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Feature:ViewComponent
    {
        FeatureManager fm = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {
            var values = fm.TGetList();
            return View(values);
        }
    }
}
