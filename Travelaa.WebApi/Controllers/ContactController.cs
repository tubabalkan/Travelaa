﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Travelaa.BusinessLayer.Abstract;
using Travelaa.EntityLayer.Concrete;

namespace Travelaa.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            contact.Date = Convert.ToDateTime(DateTime.Now.ToString());
            _contactService.TInsert(contact);
            return Ok();
        }

    }
}
