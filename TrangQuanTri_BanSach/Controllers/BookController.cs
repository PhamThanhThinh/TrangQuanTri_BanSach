using Microsoft.AspNetCore.Mvc;
using TrangQuanTri_BanSach.Repo.Abstract;

namespace TrangQuanTri_BanSach.Controllers
{
  public class BookController : Controller
  {
    private readonly IAuthorService _authorService;

    public IActionResult Index()
    {
      return View();
    }
  }
}
