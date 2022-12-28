using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalCoreProje.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentDal());

        [HttpGet]
        public PartialViewResult AddComment(int id)
        {
            ViewBag.i = id;
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(Comment p)
        {
            p.Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.State = true;
            cm.TAdd(p);
            return RedirectToAction("Index","Destination");
        }
    }
}
