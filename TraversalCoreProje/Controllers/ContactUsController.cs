using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactService;
        public ContactUsController(IContactUsService contactService)
        {
            _contactService = contactService;
        }

        public IActionResult Index()
        {
            var values = _contactService.TGetList();
            return View(values);
        }
    }
}
