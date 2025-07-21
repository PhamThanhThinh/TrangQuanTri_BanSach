using Microsoft.AspNetCore.Mvc;
using System.Net.WebSockets;
using TrangQuanTri_BanSach.Models.Domain;
using TrangQuanTri_BanSach.Repo.Abstract;

namespace TrangQuanTri_BanSach.Controllers
{
  public class GenreController : Controller
  {
    //private readonly IGenreService genreService;
    private readonly IGenreService _genreService;

    public GenreController(IGenreService genreService)
    {
      //this.genreService = genreService;
      _genreService = genreService;
    }

    [HttpGet]
    public IActionResult Add()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Add(Genre model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }
      var result = _genreService.Add(model);
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
      var record = _genreService.FindById(id);
      return View(record);
    }

    [HttpPost]
    public IActionResult Update(Genre model)
    {
      if (!ModelState.IsValid)
      {
        return View(model);
      }
      var result = _genreService.Update(model);
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
      var result = _genreService.Delete(id);
      return RedirectToAction("GetAll");
    }

    public IActionResult GetAll()
    {
      var ketqua = _genreService.GetAll();
      return View(ketqua);
    }

  }
}
