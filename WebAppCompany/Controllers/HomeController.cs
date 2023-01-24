using Company.DAL;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace WebAppCompany.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.textFields.GetTextFieldByCodeword("PageIndex"));
        }

        public IActionResult Contacts()
        {
            return View(dataManager.textFields.GetTextFieldByCodeword("PageContacts"));
        }
    }
}