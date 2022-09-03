using ContactsManagementSoft.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ContactsManagementSoft.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;

        public ContactController(ILogger<ContactController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<ContactModel> contacts = new List<ContactModel>() { new ContactModel() { ID = 1, Contact = "PH GOSTOSO", Name = "PH", Email = "safadao@gmail.com" } };
            return View(contacts);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

    }
}