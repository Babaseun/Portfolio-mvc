using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    public IActionResult Skills()
    {
      return View();
    }
    public IActionResult Projects()
    {
      return View();
    }
  }
}
