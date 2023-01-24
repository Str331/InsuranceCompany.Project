using Company.DAL;
using Microsoft.AspNetCore.Mvc;

namespace CompanyProj.Controllers
{
    public class ServicesController : Controller
    {
        private readonly DataManager dataManager;

        public ServicesController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index(Guid id)
        {
            if (id != default)
            {
                return View("Show", dataManager.serviceItems.GetServiceItemById(id));
            }

            ViewBag.TextField = dataManager.textFields.GetTextFieldByCodeword("PageServices");
            return View(dataManager.serviceItems.GetServiceItems());
        }
    }
}
