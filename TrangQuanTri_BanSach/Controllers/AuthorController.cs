using Microsoft.AspNetCore.Mvc;
using TrangQuanTri_BanSach.Models.Domain;
using TrangQuanTri_BanSach.Repo.Abstract;
using TrangQuanTri_BanSach.Repo.Implement;

namespace TrangQuanTri_BanSach.Controllers
{
  public class AuthorController : Controller
  {
    private readonly IAuthorService _authorService;

    public AuthorController(IAuthorService authorService)
    {
      _authorService = authorService;
    }

    [HttpGet]
    public IActionResult Add()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Add(Author model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }
      var result = _authorService.Add(model);
      if (result)
      {
        TempData["msg"] = "Thêm Thành Công";
        return RedirectToAction(nameof(Add));
      }
      TempData["msg"] = "Thêm Không Thành Công";

      return View(model);
    }

    [HttpGet]
    public IActionResult Update(int id)
    {
      var record = _authorService.FindById(id);
      return View(record);
    }

    [HttpPost]
    public IActionResult Update(Author model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }
      var result = _authorService.Update(model);
      if (result)
      {
        TempData["msg"] = "Sửa Thành Công";
        return RedirectToAction(nameof(Update));
      }
      TempData["msg"] = "Sửa Không Thành Công";

      return View(model);
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
      var result = _authorService.Delete(id);
      return RedirectToAction("GetAll");
    }

    public IActionResult GetAll()
    {
      var ketqua = _authorService.GetAll();
      return View(ketqua);
    }

  }
}
