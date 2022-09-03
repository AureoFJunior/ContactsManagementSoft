using ContactsManagementSoft.DataBase;
using ContactsManagementSoft.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ContactsManagementSoft.Controllers
{
    public class ContactController : Controller
    {
        private readonly ILogger<ContactController> _logger;
        private readonly Context Context;

        public ContactController(ILogger<ContactController> logger, [FromServices] Context context)
        {
            _logger = logger;
            Context = context;
        }

        public IActionResult Index()
        {
            List<ContactModel> contacts = Context.ContactModel.ToList();

            if (contacts == null)
                contacts = new List<ContactModel>();

            return View(contacts);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Create(ContactModel model)
        {
            try
            {
                var contactCreated = Context.ContactModel.Add(model);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex) { return View(); }
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Edit(ContactModel model)
        {
            try
            {
                var contactUpdated = Context.ContactModel.Update(model);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex) { return View(); }
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            try
            {
                ContactModel model = Context.ContactModel.Find(id);
                var contactCreated = Context.ContactModel.Remove(model);
                Context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex) { return View(); }
        }

        public IActionResult Details(int id)
        {
            var model = Context.ContactModel.Find(id);
            return View(model);
        }

    }
}