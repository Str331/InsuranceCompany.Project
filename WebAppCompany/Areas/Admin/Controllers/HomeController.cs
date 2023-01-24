using Company.DAL;
using Microsoft.AspNetCore.Mvc;

namespace CompanyProj.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly DataManager dataManager;

        public HomeController(DataManager dataManager)
        {
            this.dataManager = dataManager;
        }

        public IActionResult Index()
        {
            return View(dataManager.serviceItems.GetServiceItems());
        }
    }
}
