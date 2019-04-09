using Microsoft.AspNetCore.Mvc;
using ViewsProject.Areas.Admin.Repository;

namespace ViewsProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly MemoryRepository _repository = new MemoryRepository();

        public ViewResult Index()
        {
            return View(_repository.Clients);
        }
    }
}