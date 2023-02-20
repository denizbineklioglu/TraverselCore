using AutoMapper;
using BusinessLayer.Abstract;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Runtime.CompilerServices;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]
    public class ContactUsController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;
        public ContactUsController(IContactUsService contactService, IMapper mapper)
        {
            _contactUsService = contactService;
            _mapper = mapper;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SendMessageDto model)
        {
            if (ModelState.IsValid)
            {
                _contactUsService.TAdd(new ContactUs
                {
                    Name = model.Name,
                    Mail = model.Mail,
                    MessageBody = model.MessageBody,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortTimeString()),
                    Status = true
                });
                return RedirectToAction("Index","Default");
            }
            return View(model);
        }
    }
}
